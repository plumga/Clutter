using UnityEngine;
using Object = UnityEngine.Object;

namespace Clutter
{
    internal class Patches
    {
        private static Vector3 PlacementOffset = Vector3.zero;
         
        public static void SetupPlacementHooks()
        {
            On.Player.SetupPlacementGhost += OnSetupPlacementGhost;
            On.Player.UpdatePlacementGhost += OnUpdatePlacementGhost;
            On.Player.PieceRayTest += OnPieceRayTest;
            On.Player.UpdatePlacement += OnUpdatePlacement;
        }

        //Reset the placement offset whenever the placer chooses another piece
        private static void OnSetupPlacementGhost(On.Player.orig_SetupPlacementGhost orig, Player self)
        {
            PlacementOffset = Vector3.zero;
            orig(self);
        }

        //Move the point where the ghost & piece will be placed
        private static bool OnPieceRayTest(On.Player.orig_PieceRayTest orig, Player self, out Vector3 point, out Vector3 normal, out Piece piece, out Heightmap heightmap, out Collider waterSurface, bool water)
        {
            bool result = orig(self, out point, out normal, out piece, out heightmap, out waterSurface, water);
            if (result && PlacementOffset != Vector3.zero && self.m_placementGhost)
            {
                point += self.m_placementGhost.transform.TransformDirection(PlacementOffset); // TransformDirection makes the offset relative to the orientation of the piece instead of to the world
            }
            return result;
        }

        //Remove the yellow placement marker when using the Clutter Bucket
        private static void OnUpdatePlacementGhost(On.Player.orig_UpdatePlacementGhost orig, Player self, bool flashGuardStone)
        {
            orig(self, flashGuardStone);
            if (self.m_placementMarkerInstance && self.m_buildPieces && self.m_buildPieces.name == "_ClutterPieceTable")
            {
                Object.Destroy(self.m_placementMarkerInstance);
            }
        }

        //Check for mouse wheel input and update the placement offset
        private static void OnUpdatePlacement(On.Player.orig_UpdatePlacement orig, Player self, bool takeInput, float dt)
        {
            orig(self, takeInput, dt);

            if (self.m_placementGhost && takeInput && self.m_buildPieces && self.m_buildPieces.name == "_ClutterPieceTable")
            {
                float scrollWheel = Input.GetAxis("Mouse ScrollWheel");
                if (scrollWheel != 0f)
                {
                    if ((Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.LeftAlt)) ||
                        (Input.GetKey(KeyCode.RightControl) && Input.GetKey(KeyCode.RightAlt)))
                    {
                        PlacementOffset.y += GetPlacementOffset(scrollWheel);
                        UndoRotation(self, scrollWheel);
                    }
                    else if (Input.GetKey(KeyCode.LeftAlt) || Input.GetKey(KeyCode.RightAlt))
                    {
                        PlacementOffset.x += GetPlacementOffset(scrollWheel);
                        UndoRotation(self, scrollWheel);
                    }
                    else if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
                    {
                        PlacementOffset.z += GetPlacementOffset(scrollWheel);
                        UndoRotation(self, scrollWheel);
                    }
                }
            }
        }

        private static float GetPlacementOffset(float scrollWheel)
        {
            bool scrollingDown = scrollWheel < 0f;
            return scrollingDown ? -Clutter.placementOffsetIncrementConfig.Value : Clutter.placementOffsetIncrementConfig.Value;
        }

        private static void UndoRotation(Player player, float scrollWheel)
        {
            if (scrollWheel < 0f)
            {
                player.m_placeRotation++;
            }
            else
            {
                player.m_placeRotation--;
            }
        }
    }
}