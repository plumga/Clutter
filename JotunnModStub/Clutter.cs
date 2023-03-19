// JotunnModStub
// a Valheim mod skeleton using Jötunn
// 
// File:    JotunnModStub.cs
// Project: JotunnModStub

using BepInEx;
using UnityEngine;
using BepInEx.Configuration;
using Jotunn;
using Jotunn.Configs;
using Jotunn.Managers;
using Jotunn.Entities;
using Jotunn.Utils;
using Logger = Jotunn.Logger;
using System;
using Object = UnityEngine.Object;

namespace Clutter
{
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    [BepInDependency(Jotunn.Main.ModGuid)]
    internal class Clutter : BaseUnityPlugin
    {
        public const string PluginGUID = "com.plumga.Clutter";
        public const string PluginName = "Clutter";
        public const string PluginVersion = "0.1.4";
        private AssetBundle assetclutter;
        private AssetBundle assetdeco;
        private AssetBundle assetfurniture;
        private AssetBundle assetkitchen;
        private AssetBundle assetsculptures;
        private AssetBundle new1;
        private AssetBundle new2;
        private AssetBundle assetevilshit;
        private AssetBundle assetnewcluttermarch2022;
      //  public static ConfigEntry<float> placementOffsetIncrementConfig;
      //  public static ConfigEntry<bool> placementOffsetEnabledConfig;
     //   public static ConfigEntry<bool> hidePlaceMarkerConfig;

        private void Awake()
        {
          //  Patches.SetupPlacementHooks();

           // SetupConfig();
            LoadAssets();
            LoadTable();

            ///////deco
            
            //buckets
            basket();
            bucketdeco();
            bucketbigdeco();
            //candles
            candlebottle();
            candlelantern();
            candlelit2();
            candlesnake();
            candle();
            candlelit();
            //books
            diary();
            diarypage();
            bluebook();
            bluebookhoriz();
            redbook();
            redbookhoriz();
            //scrolls
            quillandink();
            quillandparchment();
            scroll1();
            scroll2();
            scroll3();
            scroll4();
            scroll5();
            //paintings
            picframe1();
            picframe2();
            picframe3();
            picframe4();
            //tablecloths
            deer();
            lox();
            wolf();
            //misc
            soap();
            pipe();
            comb();
            straw();
            winebottle();
            BarberPole();
            //death
            grave();
            bonepile();
            bones1();
            bones2();
            bones3();
            bones4();
            skull();



            ///////furniture

            //itemstands
            itemstandhoriz();
            itemstandvert();
            itemstandspear();
            itemstandstake();
            //chairs
            coolchair();
            stool();
            swing();
            swingingswing();
            //tables
            roundtable();
            tablewithcloth();
            //chests
            fancychest();
            stonechest();
            //shelves
            shelf();
            shelfwbooks();
            shelfwbooksdouble();
            weaponrack();
            weaponrackfull();
            //misc
            altar();
            altarwcandle();
            tub();
            tubfull();
            winerack();
            clock();
            birdhouse();


            ///////kitchen
            //plates
            bowl();
            bowlbig();
            plate();
            platebig();
            //mugs
            mug1();
            mug2();
            //cookware
            pan();
            pot();
            //misc
            spoon();
            mortarpestle();
            rollingpin();
            fondue();
            picnicbasket();



            //////sculptures
            //wood
            sculptowl();
            sculptpelican();
            sculptdeer();
            sculptelk();
            sculptcrow();
            sculptheron();
            sculptwolf();
            sculpthorse();
            //stone
            statuecorgi();
            statuedeer();
            statueevillarge();
            statueevilsmall();
            statuehare();
            statueseed();


            //////new1
            //furniture
            bookstorage();
            bookstoragepublic();
            fancychestpublic();
            stonechestpublic();

            //deco
            hweb();
            tweb();
            vweb();

            journal();
            openbook();
            poetrybook1H();
            poetrybook1V();
            poetrybook2H();
            poetrybook2V();
            stackedbooks1();
            stackedbooks2();

            globe1();
            globe2();
            map1();
            map2();
            map3();

            dragonstatuesmall();
            dragonstatuelarge();
            Bdragonstatuesmall();
            Bdragonstatuelarge();



            //new2

            //deco
            LargeSign();

            //sculptures
            CelticIdol1();
            CelticIdol1Small();
            CelticIdol2();
            CelticIdol3();
            CelticIdol4();
            CelticIdol5();
            CelticIdol6();
            CelticIdol7();
            CelticIdol8();
            CelticIdol9();
            CelticIdol10();
            CelticIdol11();
            CelticIdol12();

            LokiSculpture();
            OdinSculpture();


            //evilshit

            //furniture
            BloodyShelf();
            BloodyTable();

            //deco
            BloodyRag();
            DevilWindow();
            FishSkele();
            HandPrint();
            Pentagram();
            PentagramVert();
            PentagramVertSM();
            PicFrame();
            PicFrameBig();
            SkullCandle();
            SkullCandle2();
            DeerHead();

            //books
            ArmBook();
            LeatherBook();
            OpenBook();
            MagicBooks();
            OuijaBook();


            //new march2022

            //furniture
            Couch1();
            Couch2();
            Couch3();
            Couch4();
            CouchBed1();
            CouchBed2();
            NewShelf();
            RectTable();
            WallShelf();

            //deco
            BearsPainting();
            VanGogh();
            BlueBook();
            GreenBook();
            RedBook();
            Pillow1();
            Pillow2();
            Pillow3();

            //kitchen
            FlintBowl();


        }

      //  private void SetupConfig()
   //     { 
     //       placementOffsetIncrementConfig = Config.Bind(
   //             "Placement", "Placement change increment", 0.01f,
     //           new ConfigDescription("Placement change when holding Ctrl and/or Alt while scrolling using the Clutter Bucket"));

   //         placementOffsetEnabledConfig = Config.Bind(
     //        "Placement", "Enable placement change with Ctrl + Alt", true,
       //      new ConfigDescription("Enable placement change when holding Ctrl and/or Alt while scrolling using the Clutter Bucket"));
            
     //       hidePlaceMarkerConfig = Config.Bind(
       //      "Placement", "Hide placement marker", true,
         //    new ConfigDescription("Hide the yellow placement marker while using the Clutter Bucket"));

      //  }

        private void LoadAssets()
        {
            assetclutter = AssetUtils.LoadAssetBundleFromResources("clutter", typeof(Clutter).Assembly);
            assetdeco = AssetUtils.LoadAssetBundleFromResources("deco", typeof(Clutter).Assembly);
            assetfurniture = AssetUtils.LoadAssetBundleFromResources("furniture", typeof(Clutter).Assembly);
            assetkitchen = AssetUtils.LoadAssetBundleFromResources("kitchen", typeof(Clutter).Assembly);
            assetsculptures = AssetUtils.LoadAssetBundleFromResources("sculptures", typeof(Clutter).Assembly);
            new1 = AssetUtils.LoadAssetBundleFromResources("new1", typeof(Clutter).Assembly);
            new2 = AssetUtils.LoadAssetBundleFromResources("new2", typeof(Clutter).Assembly);
            assetevilshit = AssetUtils.LoadAssetBundleFromResources("evilshit", typeof(Clutter).Assembly);
            assetnewcluttermarch2022 = AssetUtils.LoadAssetBundleFromResources("newcluttermarch2022", typeof(Clutter).Assembly);

        }

        //assetclutter

        //  private void LoadTable()
       //    { 
        //       PieceManager.Instance.AddPieceTable(assetclutter.LoadAsset<GameObject>("_ClutterPieceTable"));
       //       LoadClutterTool();


      //    }

        private void LoadTable()
        {
            // Add a custom piece table with custom categories
            var table_prefab = assetclutter.LoadAsset<GameObject>("_ClutterPieceTable");
            CustomPieceTable clutter_table = new CustomPieceTable(table_prefab,
                new PieceTableConfig
                {
                    CanRemovePieces = true,
                    UseCategories = false,
                    UseCustomCategories = true,
                    CustomCategories = new string[]
                    {
                        "Sculptures", "Kitchen", "Decor", "Amenities"
                    }
                }
            );
            PieceManager.Instance.AddPieceTable(clutter_table);

            LoadClutterTool();
        }

        


        private void LoadClutterTool()
        {
            var ctoolfab = assetclutter.LoadAsset<GameObject>("$PlumgaClutterTool");
            var ctool = new CustomItem(ctoolfab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    CraftingStation = "piece_workbench",
                    RepairStation = "piece_workbench",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "Wood", Amount = 2, AmountPerLevel = 1}
                    }
                });
            ItemManager.Instance.AddItem(ctool);

        }


        ///new2
        //deco

        private void LargeSign()
        {
            var largesignfab = new2.LoadAsset<GameObject>("$custompiece_largesign");

            var largesign = new CustomPiece(largesignfab, fixReference: false,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 5, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(largesign);
        }


        //sculptures

        private void CelticIdol1()
        {
            var celticidol1fab = new2.LoadAsset<GameObject>("$custompiece_celticidol1");

            var celticidol1 = new CustomPiece(celticidol1fab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Sculptures",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Stone", Amount = 25, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(celticidol1);
        }

        private void CelticIdol1Small()
        {
            var celticidol1sfab = new2.LoadAsset<GameObject>("$custompiece_celticidol1small");

            var celticidol1s = new CustomPiece(celticidol1sfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Sculptures",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Stone", Amount = 15, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(celticidol1s);
        }


        private void CelticIdol2()
        {
            var celticidol2fab = new2.LoadAsset<GameObject>("$custompiece_celticidol2");

            var celticidol2 = new CustomPiece(celticidol2fab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Sculptures",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Stone", Amount = 25, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(celticidol2);
        }

        private void CelticIdol3()
        {
            var celticidol3fab = new2.LoadAsset<GameObject>("$custompiece_celticidol3");

            var celticidol3 = new CustomPiece(celticidol3fab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Sculptures",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Stone", Amount = 25, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(celticidol3);
        }

        private void CelticIdol4()
        {
            var celticidol4fab = new2.LoadAsset<GameObject>("$custompiece_celticidol4");

            var celticidol4 = new CustomPiece(celticidol4fab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Sculptures",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Stone", Amount = 25, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(celticidol4);
        }

        private void CelticIdol5()
        {
            var celticidol5fab = new2.LoadAsset<GameObject>("$custompiece_celticidol5");

            var celticidol5 = new CustomPiece(celticidol5fab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Sculptures",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Stone", Amount = 25, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(celticidol5);
        }

        private void CelticIdol6()
        {
            var celticidol6fab = new2.LoadAsset<GameObject>("$custompiece_celticidol6");

            var celticidol6 = new CustomPiece(celticidol6fab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Sculptures",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Stone", Amount = 25, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(celticidol6);
        }

        private void CelticIdol7()
        {
            var celticidol7fab = new2.LoadAsset<GameObject>("$custompiece_celticidol7");

            var celticidol7 = new CustomPiece(celticidol7fab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Sculptures",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Stone", Amount = 25, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(celticidol7);
        }

        private void CelticIdol8()
        {
            var celticidol8fab = new2.LoadAsset<GameObject>("$custompiece_celticidol8");

            var celticidol8 = new CustomPiece(celticidol8fab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Sculptures",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Stone", Amount = 25, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(celticidol8);
        }

        private void CelticIdol9()
        {
            var celticidol9fab = new2.LoadAsset<GameObject>("$custompiece_celticidol9");

            var celticidol9 = new CustomPiece(celticidol9fab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Sculptures",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Stone", Amount = 25, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(celticidol9);
        }

        private void CelticIdol10()
        {
            var celticidol10fab = new2.LoadAsset<GameObject>("$custompiece_celticidol10");

            var celticidol10 = new CustomPiece(celticidol10fab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Sculptures",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Stone", Amount = 25, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(celticidol10);
        }

        private void CelticIdol11()
        {
            var celticidol11fab = new2.LoadAsset<GameObject>("$custompiece_celticidol11");

            var celticidol11 = new CustomPiece(celticidol11fab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Sculptures",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Stone", Amount = 25, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(celticidol11);
        }

        private void CelticIdol12()
        {
            var celticidol12fab = new2.LoadAsset<GameObject>("$custompiece_celticidol12");

            var celticidol12 = new CustomPiece(celticidol12fab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Sculptures",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Stone", Amount = 25, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(celticidol12);
        }

        private void LokiSculpture()
        {
            var lokisculptfab = new2.LoadAsset<GameObject>("$custompiece_lokistatue");

            var lokisculpt = new CustomPiece(lokisculptfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Sculptures",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Iron", Amount = 20, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(lokisculpt);
        }

        private void OdinSculpture()
        {
            var odinsculptfab = new2.LoadAsset<GameObject>("$custompiece_odinstatue");

            var odinsculpt = new CustomPiece(odinsculptfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Sculptures",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Iron", Amount = 25, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(odinsculpt);
        }






        /////new1
        //furniture
        private void bookstorage()
        {
            var bookstoragefab = new1.LoadAsset<GameObject>("$custompiece_booksecretstorage");

            var bookstorage = new CustomPiece(bookstoragefab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Amenities",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(bookstorage);
        }

        private void bookstoragepublic()
        {
            var bookstoragepfab = new1.LoadAsset<GameObject>("$custompiece_booksecretstorage_public");

            var bookstoragep = new CustomPiece(bookstoragepfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Amenities",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(bookstoragep);
        }

        private void fancychestpublic()
        {
            var fancychestpfab = new1.LoadAsset<GameObject>("$custompiece_fancychest_public");

            var fancychestp = new CustomPiece(fancychestpfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Amenities",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "FineWood", Amount = 5, Recover = true},
                        new RequirementConfig {Item = "Bronze", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(fancychestp);
        }

        private void stonechestpublic()
        {
            var stonechestpfab = new1.LoadAsset<GameObject>("$custompiece_stonechest_public");

            var stonechestp = new CustomPiece(stonechestpfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Amenities",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Stone", Amount = 5, Recover = true},
                        new RequirementConfig {Item = "Bronze", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(stonechestp);
        }

        //decor

        private void hweb()
        {
            var hwebfab = new1.LoadAsset<GameObject>("$custompiece_horizontalweb");

            var hweb = new CustomPiece(hwebfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "BoneFragments", Amount = 1, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(hweb);
        }

        private void tweb()
        {
            var twebfab = new1.LoadAsset<GameObject>("$custompiece_tunnelweb");

            var tweb = new CustomPiece(twebfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "BoneFragments", Amount = 1, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(tweb);
        }

        private void vweb()
        {
            var vwebfab = new1.LoadAsset<GameObject>("$custompiece_verticalweb");

            var vweb = new CustomPiece(vwebfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "BoneFragments", Amount = 1, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(vweb);
        }

        //books
        private void journal()
        {
            var journalfab = new1.LoadAsset<GameObject>("$custompiece_journal");

            var journal = new CustomPiece(journalfab, fixReference: false,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(journal);
        }

        private void openbook()
        {
            var openbookfab = new1.LoadAsset<GameObject>("$custompiece_openbook");

            var openbook = new CustomPiece(openbookfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(openbook);
        }


        private void poetrybook1H()
        {
            var pb1hfab = new1.LoadAsset<GameObject>("$custompiece_poetrybook1H");

            var pb1h = new CustomPiece(pb1hfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(pb1h);
        }

        private void poetrybook1V()
        {
            var pb1vfab = new1.LoadAsset<GameObject>("$custompiece_poetrybook1V");

            var pb1v = new CustomPiece(pb1vfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(pb1v);
        }

        private void poetrybook2H()
        {
            var pb2hfab = new1.LoadAsset<GameObject>("$custompiece_poetrybook2H");

            var pb2h = new CustomPiece(pb2hfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(pb2h);
        }

        private void poetrybook2V()
        {
            var pb2vfab = new1.LoadAsset<GameObject>("$custompiece_poetrybook2V");

            var pb2v = new CustomPiece(pb2vfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(pb2v);
        }


        private void stackedbooks1()
        {
            var stackedbooks1fab = new1.LoadAsset<GameObject>("$custompiece_stackedpoetrybooks1");

            var stackedbooks1 = new CustomPiece(stackedbooks1fab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 6, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(stackedbooks1);
        }

        private void stackedbooks2()
        {
            var stackedbooks2fab = new1.LoadAsset<GameObject>("$custompiece_stackedpoetrybooks2");

            var stackedbooks2 = new CustomPiece(stackedbooks2fab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 6, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(stackedbooks2);
        }


        private void globe1()
        {
            var globefab = new1.LoadAsset<GameObject>("$custompiece_globe1");

            var globe = new CustomPiece(globefab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 3, Recover = true},
                        new RequirementConfig {Item = "Coal", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(globe);
        }

        private void globe2()
        {
            var globe2fab = new1.LoadAsset<GameObject>("$custompiece_globe2");

            var globe2 = new CustomPiece(globe2fab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 6, Recover = true},
                        new RequirementConfig {Item = "Iron", Amount = 4, Recover = true},
                        new RequirementConfig {Item = "Coal", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(globe2);
        }

        private void map1()
        {
            var mapfab = new1.LoadAsset<GameObject>("$custompiece_map1");

            var map = new CustomPiece(mapfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true},
                        new RequirementConfig {Item = "Coal", Amount = 1, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(map);
        }

        private void map2()
        {
            var map2fab = new1.LoadAsset<GameObject>("$custompiece_map2");

            var map2 = new CustomPiece(map2fab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true},
                        new RequirementConfig {Item = "Coal", Amount = 1, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(map2);
        }

        private void map3()
        {
            var map3fab = new1.LoadAsset<GameObject>("$custompiece_map3");

            var map3 = new CustomPiece(map3fab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 4, Recover = true},
                        new RequirementConfig {Item = "Coal", Amount = 1, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(map3);
        }


        private void dragonstatuesmall()
        {
            var dragstatfab = new1.LoadAsset<GameObject>("$custompiece_dragonstatuesmall");

            var dragstat = new CustomPiece(dragstatfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Sculptures",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Bronze", Amount = 10, Recover = true},
                        new RequirementConfig {Item = "Copper", Amount = 10, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(dragstat);
        }

        private void dragonstatuelarge()
        {
            var dragstatlfab = new1.LoadAsset<GameObject>("$custompiece_dragonstatuelarge");

            var dragstatl = new CustomPiece(dragstatlfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Sculptures",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Bronze", Amount = 25, Recover = true},
                        new RequirementConfig {Item = "Copper", Amount = 25, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(dragstatl);
        }

        private void Bdragonstatuesmall()
        {
            var bdragstatfab = new1.LoadAsset<GameObject>("$custompiece_blackdragonstatuesmall");

            var bdragstat = new CustomPiece(bdragstatfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Sculptures",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Iron", Amount = 10, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(bdragstat);
        }

        private void Bdragonstatuelarge()
        {
            var bdragstatlfab = new1.LoadAsset<GameObject>("$custompiece_blackdragonstatuelarge");

            var bdragstatl = new CustomPiece(bdragstatlfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Sculptures",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Iron", Amount = 30, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(bdragstatl);
        }



        /////deco
        //buckets
        private void basket()
        {
            var basketfab = assetdeco.LoadAsset<GameObject>("$custompiece_basket");

            var basket = new CustomPiece(basketfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(basket);
        }

        private void bucketdeco()
        {
            var decobucketfab = assetdeco.LoadAsset<GameObject>("$custompiece_bucket");

            var decobucket = new CustomPiece(decobucketfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 3, Recover = true},
                        new RequirementConfig {Item = "BronzeNails", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(decobucket);
        }

        private void bucketbigdeco()
        {
            var decobucketbigfab = assetdeco.LoadAsset<GameObject>("$custompiece_bucketbig");

            var decobucketbig = new CustomPiece(decobucketbigfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 5, Recover = true},
                        new RequirementConfig {Item = "BronzeNails", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(decobucketbig);
        }


        //candles

        private void candlebottle()
        {
            var candlebfab = assetdeco.LoadAsset<GameObject>("$custompiece_candlebottle");

            var candleb = new CustomPiece(candlebfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Honey", Amount = 2, Recover = true},
                        new RequirementConfig {Item = "Flint", Amount = 5, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(candleb);
        }

        private void candlelantern()
        {
            var candlelfab = assetdeco.LoadAsset<GameObject>("$custompiece_candlelantern");

            var candlel = new CustomPiece(candlelfab, fixReference: false,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Honey", Amount = 2, Recover = true},
                        new RequirementConfig {Item = "Flint", Amount = 5, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(candlel);
        }

        private void candlelit2()
        {
            var candlelit2fab = assetdeco.LoadAsset<GameObject>("$custompiece_candlelit2");

            var candlelit2 = new CustomPiece(candlelit2fab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Honey", Amount = 2, Recover = true},
                        new RequirementConfig {Item = "Flint", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(candlelit2);
        }

        private void candlesnake()
        {
            var candlesfab = assetdeco.LoadAsset<GameObject>("$custompiece_candlesnake");

            var candles = new CustomPiece(candlesfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Honey", Amount = 2, Recover = true},
                        new RequirementConfig {Item = "Flint", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(candles);
        }

        private void candle()
        {
            var candlefab = assetdeco.LoadAsset<GameObject>("$custompiece_dunmr_candle");

            var candle = new CustomPiece(candlefab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Honey", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(candle);
        }


        private void candlelit()
        {
            var candlelitfab = assetdeco.LoadAsset<GameObject>("$custompiece_dunmr_candlelit");

            var candlelit = new CustomPiece(candlelitfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Honey", Amount = 2, Recover = true},
                        new RequirementConfig {Item = "Flint", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(candlelit);
        }

        //books

        private void diary()
        {
            var diaryfab = assetdeco.LoadAsset<GameObject>("$custompiece_diary");

            var diary = new CustomPiece(diaryfab, fixReference: false,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true},
                        new RequirementConfig {Item = "Coal", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(diary);
        }

        private void diarypage()
        {
            var diarypfab = assetdeco.LoadAsset<GameObject>("$custompiece_diarypage");

            var diaryp = new CustomPiece(diarypfab, fixReference: false,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true},
                        new RequirementConfig {Item = "Coal", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(diaryp);
        }

        private void bluebook()
        {
            var bookbluefab = assetdeco.LoadAsset<GameObject>("$custompiece_dunmr_bookblue");

            var bookblue = new CustomPiece(bookbluefab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(bookblue);
        }

        private void bluebookhoriz()
        {
            var bookbluehfab = assetdeco.LoadAsset<GameObject>("$custompiece_dunmr_bookblue_horiz");

            var bookblueh = new CustomPiece(bookbluehfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(bookblueh);
        }



        private void redbook()
        {
            var bookredfab = assetdeco.LoadAsset<GameObject>("$custompiece_dunmr_bookred");

            var bookred = new CustomPiece(bookredfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(bookred);
        }

        private void redbookhoriz()
        {
            var bookredhfab = assetdeco.LoadAsset<GameObject>("$custompiece_dunmr_bookred_horiz");

            var bookredh = new CustomPiece(bookredhfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(bookredh);
        }


        //scrolls
        private void quillandink()
        {
            var qifab = assetdeco.LoadAsset<GameObject>("$custompiece_quillandink");

            var qi = new CustomPiece(qifab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Coal", Amount = 2, Recover = true},
                        new RequirementConfig {Item = "Feathers", Amount = 1, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(qi);
        }

        private void quillandparchment()
        {
            var qpfab = assetdeco.LoadAsset<GameObject>("$custompiece_quillandparchment");

            var qp = new CustomPiece(qpfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true},
                        new RequirementConfig {Item = "Coal", Amount = 2, Recover = true},
                        new RequirementConfig {Item = "Feathers", Amount = 1, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(qp);
        }

        //scrolls
        private void scroll1()
        {
            var scrollfab = assetdeco.LoadAsset<GameObject>("$custompiece_scroll1");

            var scroll = new CustomPiece(scrollfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(scroll);
        }

        private void scroll2()
        {
            var scroll2fab = assetdeco.LoadAsset<GameObject>("$custompiece_scroll2");

            var scroll2 = new CustomPiece(scroll2fab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(scroll2);
        }

        private void scroll3()
        {
            var scroll3fab = assetdeco.LoadAsset<GameObject>("$custompiece_scroll3");

            var scroll3 = new CustomPiece(scroll3fab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(scroll3);
        }

        private void scroll4()
        {
            var scroll4fab = assetdeco.LoadAsset<GameObject>("$custompiece_scroll4");

            var scroll4 = new CustomPiece(scroll4fab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(scroll4);
        }

        private void scroll5()
        {
            var scroll5fab = assetdeco.LoadAsset<GameObject>("$custompiece_scroll5");

            var scroll5 = new CustomPiece(scroll5fab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(scroll5);
        }

        //paintings
        private void picframe1()
        {
            var pf1fab = assetdeco.LoadAsset<GameObject>("$custompiece_pictureframe1");

            var pf1 = new CustomPiece(pf1fab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true},
                        new RequirementConfig {Item = "BronzeNails", Amount = 1, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(pf1);
        }

        private void picframe2()
        {
            var pf2fab = assetdeco.LoadAsset<GameObject>("$custompiece_pictureframe2");

            var pf2 = new CustomPiece(pf2fab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true},
                        new RequirementConfig {Item = "BronzeNails", Amount = 1, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(pf2);
        }

        private void picframe3()
        {
            var pf3fab = assetdeco.LoadAsset<GameObject>("$custompiece_pictureframe3");

            var pf3 = new CustomPiece(pf3fab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true},
                        new RequirementConfig {Item = "BronzeNails", Amount = 1, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(pf3);
        }

        private void picframe4()
        {
            var pf4fab = assetdeco.LoadAsset<GameObject>("$custompiece_pictureframe4");

            var pf4 = new CustomPiece(pf4fab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true},
                        new RequirementConfig {Item = "BronzeNails", Amount = 1, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(pf4);
        }

        //tablecloth
        private void deer()
        {
            var deerfab = assetdeco.LoadAsset<GameObject>("$custompiece_rug_deer_tablecloth");

            var deer = new CustomPiece(deerfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "DeerHide", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(deer);
        }


        private void lox()
        {
            var loxfab = assetdeco.LoadAsset<GameObject>("$custompiece_rug_fur_tablecloth");

            var lox = new CustomPiece(loxfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "LoxPelt", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(lox);
        }


        private void wolf()
        {
            var wolffab = assetdeco.LoadAsset<GameObject>("$custompiece_rug_wolf_tablecloth");

            var wolf = new CustomPiece(wolffab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "WolfPelt", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(wolf);
        }



        //misc
        private void soap()
        {
            var soapfab = assetdeco.LoadAsset<GameObject>("$custompiece_soap");

            var soap = new CustomPiece(soapfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Coal", Amount = 1, Recover = true},
                        new RequirementConfig {Item = "RawMeat", Amount = 1, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(soap);
        }

        private void pipe()
        {
            var pipefab = assetdeco.LoadAsset<GameObject>("$custompiece_pipe");

            var pipe = new CustomPiece(pipefab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(pipe);
        }

        private void comb()
        {
            var combfab = assetdeco.LoadAsset<GameObject>("$custompiece_dunmr_comb");

            var comb = new CustomPiece(combfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 1, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(comb);
        }

        private void straw()
        {
            var strawfab = assetdeco.LoadAsset<GameObject>("$custompiece_straw");

            var straw = new CustomPiece(strawfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Flax", Amount = 5, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(straw);
        }

        private void winebottle()
        {
            var winebottlefab = assetdeco.LoadAsset<GameObject>("$custompiece_winebottle");

            var winebottle = new CustomPiece(winebottlefab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "MeadTasty", Amount = 1, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(winebottle);
        }

        private void BarberPole()
        {
            var bpfab = assetdeco.LoadAsset<GameObject>("$custompiece_barberpole");

            var bp = new CustomPiece(bpfab, fixReference: false,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Bronze", Amount = 3, Recover = true},
                        new RequirementConfig {Item = "Flint", Amount = 3, Recover = true},
                        new RequirementConfig {Item = "Blueberries", Amount = 3, Recover = true},
                        new RequirementConfig {Item = "Raspberry", Amount = 3, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(bp);
        }



        //death
        private void grave()
        {
            var gravefab = assetdeco.LoadAsset<GameObject>("$custompiece_gravestone");

            var grave = new CustomPiece(gravefab, fixReference: false,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Stone", Amount = 3, Recover = true},
                        new RequirementConfig {Item = "Coal", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(grave);
        }

        private void bonepile()
        {
            var bonepilefab = assetdeco.LoadAsset<GameObject>("$custompiece_bonepile");

            var bonepile = new CustomPiece(bonepilefab, fixReference: false,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "BoneFragments", Amount = 20, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(bonepile);
        }
        private void bones1()
        {
            var bones1fab = assetdeco.LoadAsset<GameObject>("$custompiece_bones1");

            var bones1 = new CustomPiece(bones1fab, fixReference: false,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "BoneFragments", Amount = 5, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(bones1);
        }
        private void bones2()
        {
            var bones2fab = assetdeco.LoadAsset<GameObject>("$custompiece_bones2");

            var bones2 = new CustomPiece(bones2fab, fixReference: false,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "BoneFragments", Amount = 5, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(bones2);
        }
        private void bones3()
        {
            var bones3fab = assetdeco.LoadAsset<GameObject>("$custompiece_bones3");

            var bones3 = new CustomPiece(bones3fab, fixReference: false,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "BoneFragments", Amount = 5, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(bones3);
        }
        private void bones4()
        {
            var bones4fab = assetdeco.LoadAsset<GameObject>("$custompiece_bones4");

            var bones4 = new CustomPiece(bones4fab, fixReference: false,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "BoneFragments", Amount = 10, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(bones4);
        }

        private void skull()
        {
            var skullfab = assetdeco.LoadAsset<GameObject>("$custompiece_skull");

            var skull = new CustomPiece(skullfab, fixReference: false,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "BoneFragments", Amount = 3, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(skull);
        }




        /////furniture


        //itemstands
        private void itemstandhoriz()
        {
            var standhfab = assetfurniture.LoadAsset<GameObject>("$custompiece_itemstand_horizontal_reduced");

            var standh = new CustomPiece(standhfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Amenities",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 1, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(standh);
        }

        private void itemstandvert()
        {
            var standvfab = assetfurniture.LoadAsset<GameObject>("$custompiece_itemstand_vertical_reduced");

            var standv = new CustomPiece(standvfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Amenities",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 1, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(standv);
        }

        private void itemstandspear()
        {
            var standspfab = assetfurniture.LoadAsset<GameObject>("$custompiece_itemstand_spear");

            var standsp = new CustomPiece(standspfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Amenities",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(standsp);
        }

        private void itemstandstake()
        {
            var standstfab = assetfurniture.LoadAsset<GameObject>("$custompiece_itemstand_stake");

            var standst = new CustomPiece(standstfab, fixReference: false,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Amenities",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(standst);
        }

        //chairs

        private void coolchair()
        {
            var coolchairfab = assetfurniture.LoadAsset<GameObject>("$custompiece_coolchair");

            var coolchair = new CustomPiece(coolchairfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Amenities",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "FineWood", Amount = 3, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(coolchair);
        }

        private void stool()
        {
            var stoolfab = assetnewcluttermarch2022.LoadAsset<GameObject>("$custompiece_stool");

            var stool = new CustomPiece(stoolfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Amenities",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(stool);
        }



        private void swing()
        {
            var swingfab = assetfurniture.LoadAsset<GameObject>("$custompiece_swing");

            var swing = new CustomPiece(swingfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Amenities",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 10, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(swing);
        }

        private void swingingswing()
        {
            var swingtestfab = assetnewcluttermarch2022.LoadAsset<GameObject>("$custompiece_swingingswing");

            var swingtest = new CustomPiece(swingtestfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Amenities",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 10, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(swingtest);
        }


        //chairs
        private void roundtable()
        {
            var roundtablefab = assetnewcluttermarch2022.LoadAsset<GameObject>("$custompiece_roundtable");

            var roundtable = new CustomPiece(roundtablefab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Amenities",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 5, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(roundtable);
        }

        private void tablewithcloth()
        {
            var clothtablefab = assetnewcluttermarch2022.LoadAsset<GameObject>("$custompiece_roundtablewithcloth");

            var clothtable = new CustomPiece(clothtablefab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Amenities",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 5, Recover = true},
                        new RequirementConfig {Item = "DeerHide", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(clothtable);
        }

        //chests
        private void fancychest()
        {
            var chest2fab = assetfurniture.LoadAsset<GameObject>("$custompiece_fancychest");

            var chest2 = new CustomPiece(chest2fab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Amenities",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "FineWood", Amount = 10, Recover = true},
                        new RequirementConfig {Item = "Bronze", Amount = 5, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(chest2);
        }


        private void stonechest()
        {
            var chest1fab = assetfurniture.LoadAsset<GameObject>("$custompiece_stonechest");

            var chest1 = new CustomPiece(chest1fab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Amenities",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Stone", Amount = 10, Recover = true},
                        new RequirementConfig {Item = "Bronze", Amount = 5, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(chest1);
        }

        //shelves
        private void shelf()
        {
            var shelffab = assetfurniture.LoadAsset<GameObject>("$custompiece_dunmr_shelf");

            var shelf = new CustomPiece(shelffab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Amenities",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 5, Recover = true},
                        new RequirementConfig {Item = "FineWood", Amount = 10, Recover = true},
                        new RequirementConfig {Item = "BronzeNails", Amount = 6, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(shelf);
        }

        private void shelfwbooks()
        {
            var bookshelffab = assetfurniture.LoadAsset<GameObject>("$custompiece_dunmr_shelfwithbooks");

            var bookshelf = new CustomPiece(bookshelffab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Amenities",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 10, Recover = true},
                        new RequirementConfig {Item = "FineWood", Amount = 10, Recover = true},
                        new RequirementConfig {Item = "BronzeNails", Amount = 6, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(bookshelf);
        }

        private void shelfwbooksdouble()
        {
            var bookshelfdfab = assetfurniture.LoadAsset<GameObject>("$custompiece_dunmr_shelfwithbooksdouble");

            var bookshelfd = new CustomPiece(bookshelfdfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Amenities",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 20, Recover = true},
                        new RequirementConfig {Item = "FineWood", Amount = 20, Recover = true},
                        new RequirementConfig {Item = "BronzeNails", Amount = 12, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(bookshelfd);
        }


        private void weaponrack()
        {
            var weaponrackfab = assetfurniture.LoadAsset<GameObject>("$custompiece_weaponrack");

            var weaponrack = new CustomPiece(weaponrackfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Amenities",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 10, Recover = true},
                        new RequirementConfig {Item = "BronzeNails", Amount = 6, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(weaponrack);
        }

        private void weaponrackfull()
        {
            var weaponrackfullfab = assetfurniture.LoadAsset<GameObject>("$custompiece_weaponrack_full");

            var weaponrackfull = new CustomPiece(weaponrackfullfab, fixReference: false,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Amenities",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 10, Recover = true},
                        new RequirementConfig {Item = "Bronze", Amount = 10, Recover = true},
                        new RequirementConfig {Item = "BronzeNails", Amount = 6, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(weaponrackfull);
        }

        //misc
        private void altar()
        {
            var altarfab = assetfurniture.LoadAsset<GameObject>("$custompiece_dunmr_altar");

            var altar = new CustomPiece(altarfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Amenities",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 3, Recover = true},
                        new RequirementConfig {Item = "BronzeNails", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(altar);
        }

        private void altarwcandle()
        {
            var altarcandlefab = assetfurniture.LoadAsset<GameObject>("$custompiece_dunmr_altarwcandle");

            var altarcandle = new CustomPiece(altarcandlefab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Amenities",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 3, Recover = true},
                        new RequirementConfig {Item = "BronzeNails", Amount = 2, Recover = true},
                        new RequirementConfig {Item = "Honey", Amount = 2, Recover = true},
                        new RequirementConfig {Item = "Flint", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(altarcandle);
        }

        private void tub()
        {
            var tubfab = assetfurniture.LoadAsset<GameObject>("$custompiece_tub");

            var tub = new CustomPiece(tubfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Amenities",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 5, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(tub);
        }

        private void tubfull()
        {
            var tubfullfab = assetfurniture.LoadAsset<GameObject>("$custompiece_tubfull");

            var tubfull = new CustomPiece(tubfullfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Amenities",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 5, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(tubfull);
        }

        private void winerack()
        {
            var winerackfab = assetfurniture.LoadAsset<GameObject>("$custompiece_winerack");

            var winerack = new CustomPiece(winerackfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Amenities",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 5, Recover = true},
                        new RequirementConfig {Item = "MeadTasty", Amount = 1, Recover = true},
                        new RequirementConfig {Item = "BronzeNails", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(winerack);
        }


        private void clock()
        {
            var clockfab = assetfurniture.LoadAsset<GameObject>("$custompiece_cuckooclock");

            var clock = new CustomPiece(clockfab, fixReference: false,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Amenities",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 3, Recover = true},
                        new RequirementConfig {Item = "Flint", Amount = 2, Recover = true},
                        new RequirementConfig {Item = "BronzeNails", Amount = 4, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(clock);
        }

        private void birdhouse()
        {
            var birdhousefab = assetfurniture.LoadAsset<GameObject>("$custompiece_birdhouse");

            var birdhouse = new CustomPiece(birdhousefab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Amenities",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 3, Recover = true},
                        new RequirementConfig {Item = "BronzeNails", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(birdhouse);
        }




        //////kitchen
        //plates 
        private void bowl()
        {
            var bowlfab = assetkitchen.LoadAsset<GameObject>("$custompiece_dunmr_bowl");

            var bowl = new CustomPiece(bowlfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Kitchen",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(bowl);
        }

        private void bowlbig()
        {
            var bowlbfab = assetkitchen.LoadAsset<GameObject>("$custompiece_dunmr_bowlbig");

            var bowlb = new CustomPiece(bowlbfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Kitchen",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(bowlb);
        }


        private void plate()
        {
            var platefab = assetkitchen.LoadAsset<GameObject>("$custompiece_dunmr_plate");

            var plate = new CustomPiece(platefab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Kitchen",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(plate);
        }

        private void platebig()
        {
            var platebfab = assetkitchen.LoadAsset<GameObject>("$custompiece_dunmr_platebig");

            var plateb = new CustomPiece(platebfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Kitchen",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(plateb);
        }

        //mugs
        private void mug1()
        {
            var mug1fab = assetkitchen.LoadAsset<GameObject>("$custompiece_dunmr_mug1");

            var mug = new CustomPiece(mug1fab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Kitchen",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(mug);
        }


        private void mug2()
        {
            var mug2fab = assetkitchen.LoadAsset<GameObject>("$custompiece_dunmr_mug2");

            var mug2 = new CustomPiece(mug2fab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Kitchen",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(mug2);
        }

        //cookware
        private void pan()
        {
            var panfab = assetkitchen.LoadAsset<GameObject>("$custompiece_pan");

            var pan = new CustomPiece(panfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Kitchen",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Tin", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(pan);
        }

        private void pot()
        {
            var potfab = assetkitchen.LoadAsset<GameObject>("$custompiece_pot");

            var pot = new CustomPiece(potfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Kitchen",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Tin", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(pot);
        }

        //misc
        private void spoon()
        {
            var spoonfab = assetkitchen.LoadAsset<GameObject>("$custompiece_dunmr_spoon");

            var spoon = new CustomPiece(spoonfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Kitchen",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 1, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(spoon);
        }

        private void mortarpestle()
        {
            var mortarpestlefab = assetkitchen.LoadAsset<GameObject>("$custompiece_mortarandpestle");

            var mortarpestle = new CustomPiece(mortarpestlefab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Kitchen",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Flint", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(mortarpestle);
        }


        private void rollingpin()
        {
            var rollingpinfab = assetkitchen.LoadAsset<GameObject>("$custompiece_rollingpin");

            var rollingpin = new CustomPiece(rollingpinfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Kitchen",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(rollingpin);
        }

        private void fondue()
        {
            var fonduefab = assetkitchen.LoadAsset<GameObject>("$custompiece_fonduepot");

            var fondue = new CustomPiece(fonduefab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Kitchen",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true},
                        new RequirementConfig {Item = "Flint", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(fondue);
        }


        private void picnicbasket()
        {
            var picnicbasketfab = assetkitchen.LoadAsset<GameObject>("$custompiece_picnicbasket");

            var picnicbasket = new CustomPiece(picnicbasketfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Kitchen",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 3, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(picnicbasket);
        }





        //////sculptures
        //wood
        private void sculptowl()
        {
            var owlfab = assetsculptures.LoadAsset<GameObject>("$custompiece_barnowl");
                                                                                          
            var owl = new CustomPiece(owlfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Sculptures",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(owl);
        }


        private void sculptpelican()
        {
            var pelicanfab = assetsculptures.LoadAsset<GameObject>("$custompiece_brownpelican");

            var pelican = new CustomPiece(pelicanfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Sculptures",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(pelican);
        }


        private void sculptdeer()
        {
            var deerfab = assetsculptures.LoadAsset<GameObject>("$custompiece_deer");

            var deer = new CustomPiece(deerfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Sculptures",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(deer);
        }


        private void sculptelk()
        {
            var elkfab = assetsculptures.LoadAsset<GameObject>("$custompiece_elk");

            var elk = new CustomPiece(elkfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Sculptures",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(elk);
        }



        private void sculptcrow()
        {
            var crowfab = assetsculptures.LoadAsset<GameObject>("$custompiece_flyingcrow");

            var crow = new CustomPiece(crowfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Sculptures",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(crow);
        }



        private void sculptheron()
        {
            var heronfab = assetsculptures.LoadAsset<GameObject>("$custompiece_heron");

            var heron = new CustomPiece(heronfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Sculptures",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(heron);
        }

        private void sculpthorse()
        {
            var horsefab = assetsculptures.LoadAsset<GameObject>("$custompiece_wildhorse");

            var horse = new CustomPiece(horsefab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Sculptures",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(horse);
        }


        private void sculptwolf()
        {
            var wolffab = assetsculptures.LoadAsset<GameObject>("$custompiece_wolf");

            var wolf = new CustomPiece(wolffab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Sculptures",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(wolf);
        }


        //stone
        private void statuecorgi()
        {
            var corgifab = assetsculptures.LoadAsset<GameObject>("$custompiece_statuecorgi");

            var corgi = new CustomPiece(corgifab, fixReference: false,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Sculptures",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Stone", Amount = 5, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(corgi);
        }


        private void statuedeer()
        {
            var statuedeerfab = assetsculptures.LoadAsset<GameObject>("$custompiece_statuedeer");

            var statuedeer = new CustomPiece(statuedeerfab, fixReference: false,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Sculptures",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Stone", Amount = 10, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(statuedeer);
        }

        private void statueevillarge()
        {
            var statueevillfab = assetsculptures.LoadAsset<GameObject>("$custompiece_statueevil_large");

            var statueevill = new CustomPiece(statueevillfab, fixReference: false,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Sculptures",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Stone", Amount = 50, Recover = true},
                        new RequirementConfig {Item = "ElderBark", Amount = 10, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(statueevill);
        }

        private void statueevilsmall()
        {
            var statueevilsfab = assetsculptures.LoadAsset<GameObject>("$custompiece_statueevil_small");

            var statueevils = new CustomPiece(statueevilsfab, fixReference: false,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Sculptures",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Stone", Amount = 25, Recover = true},
                        new RequirementConfig {Item = "ElderBark", Amount = 5, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(statueevils);
        }

        private void statuehare()
        {
            var statueharefab = assetsculptures.LoadAsset<GameObject>("$custompiece_statuehare");

            var statuehare = new CustomPiece(statueharefab, fixReference: false,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Sculptures",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Stone", Amount = 5, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(statuehare);
        }


        private void statueseed()
        {
            var statueseedfab = assetsculptures.LoadAsset<GameObject>("$custompiece_statueseed");

            var statueseed = new CustomPiece(statueseedfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Sculptures",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Stone", Amount = 3, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(statueseed);
        }


        //evil

        //furniture



        private void BloodyShelf()
        {
            var bshelffab = assetevilshit.LoadAsset<GameObject>("$custompiece_bloodyshelf");

            var bshelf = new CustomPiece(bshelffab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Amenities",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 1, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(bshelf);
        }

        private void BloodyTable()
        {
            var btablefab = assetevilshit.LoadAsset<GameObject>("$custompiece_bloodytable");

            var btable = new CustomPiece(btablefab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Amenities",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 5, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(btable);
        }

        

        //deco

        private void BloodyRag()
        {
            var bragfab = assetevilshit.LoadAsset<GameObject>("$custompiece_bloodyrag");

            var brag = new CustomPiece(bragfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "LeatherScraps", Amount = 3, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(brag);
        }

        private void DevilWindow()
        {
            var devwfab = assetevilshit.LoadAsset<GameObject>("$custompiece_devilwindow");

            var devw = new CustomPiece(devwfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true},
                        new RequirementConfig {Item = "Crystal", Amount = 3, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(devw);
        }


        private void FishSkele()
        {
            var fishsfab = assetevilshit.LoadAsset<GameObject>("$custompiece_fishskeleton");

            var fishs = new CustomPiece(fishsfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "BoneFragments", Amount = 3, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(fishs);
        }

        private void HandPrint()
        {
            var hprintfab = assetevilshit.LoadAsset<GameObject>("$custompiece_handprint");

            var hprint = new CustomPiece(hprintfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Raspberry", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(hprint);
        }



        private void Pentagram()
        {
            var pfab = assetevilshit.LoadAsset<GameObject>("$custompiece_pentagram");

            var p = new CustomPiece(pfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Raspberry", Amount = 6, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(p);
        }

        private void PentagramVert()
        {
            var pvfab = assetevilshit.LoadAsset<GameObject>("$custompiece_pentagram_vertical");

            var pv = new CustomPiece(pvfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Raspberry", Amount = 6, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(pv);
        }

        private void PentagramVertSM()
        {
            var pvfab = assetevilshit.LoadAsset<GameObject>("$custompiece_pentagram_verticalsmall");

            var pv = new CustomPiece(pvfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Raspberry", Amount = 3, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(pv);
        }

        private void PicFrame()
        {
            var pffab = assetevilshit.LoadAsset<GameObject>("$custompiece_pictureframe");

            var pf = new CustomPiece(pffab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true},
                        new RequirementConfig {Item = "BronzeNails", Amount = 1, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(pf);
        }

        private void PicFrameBig()
        {
            var pffab = assetevilshit.LoadAsset<GameObject>("$custompiece_pictureframebig");

            var pf = new CustomPiece(pffab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 4, Recover = true},
                        new RequirementConfig {Item = "BronzeNails", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(pf);
        }


        private void SkullCandle()
        {
            var SCfab = assetevilshit.LoadAsset<GameObject>("$custompiece_skullcandle");

            var SC = new CustomPiece(SCfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Honey", Amount = 2, Recover = true},
                        new RequirementConfig {Item = "Flint", Amount = 2, Recover = true},
                        new RequirementConfig {Item = "BoneFragments", Amount = 3, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(SC);
        }

        private void SkullCandle2()
        {
            var SC2fab = assetevilshit.LoadAsset<GameObject>("$custompiece_skullcandle2");

            var SC2 = new CustomPiece(SC2fab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Honey", Amount = 2, Recover = true},
                        new RequirementConfig {Item = "Flint", Amount = 2, Recover = true},
                        new RequirementConfig {Item = "BoneFragments", Amount = 3, Recover = true}

                    }
                });
            PieceManager.Instance.AddPiece(SC2);
        }


        private void DeerHead()
        {
            var dhfab = assetevilshit.LoadAsset<GameObject>("$custompiece_zombiedeerhead");

            var dh = new CustomPiece(dhfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true},
                        new RequirementConfig {Item = "TrophyDeer", Amount = 1, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(dh);
        }



        //books
        private void ArmBook()
        {
            var armbookfab = assetevilshit.LoadAsset<GameObject>("$custompiece_armbook");

            var armbook = new CustomPiece(armbookfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true},
                        new RequirementConfig {Item = "BoneFragments", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(armbook);
        }

        private void LeatherBook()
        {
            var lbkfab = assetevilshit.LoadAsset<GameObject>("$custompiece_creepyleatherbook");

            var lbk = new CustomPiece(lbkfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true},
                        new RequirementConfig {Item = "LeatherScraps", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(lbk);
        }

        private void OpenBook()
        {
            var openbkfab = assetevilshit.LoadAsset<GameObject>("$custompiece_creepyopenbook");

            var openbk = new CustomPiece(openbkfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(openbk);
        }

        private void MagicBooks()
        {
            var magbksfab = assetevilshit.LoadAsset<GameObject>("$custompiece_magicbooks");

            var magbks = new CustomPiece(magbksfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 4, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(magbks);
        }

        private void OuijaBook()
        {
            var obfab = assetevilshit.LoadAsset<GameObject>("$custompiece_ouijabook");

            var ob = new CustomPiece(obfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(ob);
        }



        //new march2022

        //furniture

        private void Couch1()
        {
            var couchfab = assetnewcluttermarch2022.LoadAsset<GameObject>("$custompiece_couch1");

            var couch = new CustomPiece(couchfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Amenities",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 4, Recover = true},
                        new RequirementConfig {Item = "DeerHide", Amount = 5, Recover = true},
                        new RequirementConfig {Item = "LeatherScraps", Amount = 2, Recover = true},
                        new RequirementConfig {Item = "Feathers", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(couch);
        }

        private void Couch2()
        {
            var couchfab = assetnewcluttermarch2022.LoadAsset<GameObject>("$custompiece_couch2");

            var couch = new CustomPiece(couchfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Amenities",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 4, Recover = true},
                        new RequirementConfig {Item = "JuteRed", Amount = 4, Recover = true},
                        new RequirementConfig {Item = "LeatherScraps", Amount = 2, Recover = true},
                        new RequirementConfig {Item = "Feathers", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(couch);
        }

        private void Couch3()
        {
            var couchfab = assetnewcluttermarch2022.LoadAsset<GameObject>("$custompiece_couch3");

            var couch = new CustomPiece(couchfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Amenities",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 4, Recover = true},
                        new RequirementConfig {Item = "WolfPelt", Amount = 4, Recover = true},
                        new RequirementConfig {Item = "LeatherScraps", Amount = 2, Recover = true},
                        new RequirementConfig {Item = "Feathers", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(couch);
        }

        private void Couch4()
        {
            var couchfab = assetnewcluttermarch2022.LoadAsset<GameObject>("$custompiece_couch4");

            var couch = new CustomPiece(couchfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Amenities",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 4, Recover = true},
                        new RequirementConfig {Item = "LoxPelt", Amount = 4, Recover = true},
                        new RequirementConfig {Item = "LeatherScraps", Amount = 2, Recover = true},
                        new RequirementConfig {Item = "Feathers", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(couch);
        }

        private void CouchBed1()
        {
            var couchbfab = assetnewcluttermarch2022.LoadAsset<GameObject>("$custompiece_couchbed1");

            var couchb = new CustomPiece(couchbfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Amenities",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 4, Recover = true},
                        new RequirementConfig {Item = "DeerHide", Amount = 5, Recover = true},
                        new RequirementConfig {Item = "LeatherScraps", Amount = 2, Recover = true},
                        new RequirementConfig {Item = "Feathers", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(couchb);
        }

        private void CouchBed2()
        {
            var couchbfab = assetnewcluttermarch2022.LoadAsset<GameObject>("$custompiece_couchbed2");

            var couchb = new CustomPiece(couchbfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Amenities",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 4, Recover = true},
                        new RequirementConfig {Item = "JuteRed", Amount = 4, Recover = true},
                        new RequirementConfig {Item = "LeatherScraps", Amount = 2, Recover = true},
                        new RequirementConfig {Item = "Feathers", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(couchb);
        }


        private void NewShelf()
        {
            var couchfab = assetnewcluttermarch2022.LoadAsset<GameObject>("$custompiece_newshelf");

            var couch = new CustomPiece(couchfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Amenities",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 6, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(couch);
        }

        private void RectTable()
        {
            var couchfab = assetnewcluttermarch2022.LoadAsset<GameObject>("$custompiece_rectangulartable");

            var couch = new CustomPiece(couchfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Amenities",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 5, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(couch);
        }


        private void WallShelf()
        {
            var couchfab = assetnewcluttermarch2022.LoadAsset<GameObject>("$custompiece_wallshelf");

            var couch = new CustomPiece(couchfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Amenities",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 1, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(couch);
        }



        //deco

        private void BearsPainting()
        {
            var couchfab = assetnewcluttermarch2022.LoadAsset<GameObject>("$custompiece_bearspainting");

            var couch = new CustomPiece(couchfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true},
                        new RequirementConfig {Item = "BronzeNails", Amount = 1, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(couch);
        }


        private void VanGogh()
        {
            var couchfab = assetnewcluttermarch2022.LoadAsset<GameObject>("$custompiece_vangogh");

            var couch = new CustomPiece(couchfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true},
                        new RequirementConfig {Item = "BronzeNails", Amount = 1, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(couch);
        }



        private void BlueBook()
        {
            var couchfab = assetnewcluttermarch2022.LoadAsset<GameObject>("$custompiece_newbluebook");

            var couch = new CustomPiece(couchfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(couch);
        }

        private void GreenBook()
        {
            var couchfab = assetnewcluttermarch2022.LoadAsset<GameObject>("$custompiece_newgreenbook");

            var couch = new CustomPiece(couchfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(couch);
        }

        private void RedBook()
        {
            var couchfab = assetnewcluttermarch2022.LoadAsset<GameObject>("$custompiece_newredbook");

            var couch = new CustomPiece(couchfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(couch);
        }

       
        private void Pillow1()
        {
            var couchfab = assetnewcluttermarch2022.LoadAsset<GameObject>("$custompiece_pillow1");

            var couch = new CustomPiece(couchfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "LeatherScraps", Amount = 1, Recover = true},
                        new RequirementConfig {Item = "Feathers", Amount = 1, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(couch);
        }

        private void Pillow2()
        {
            var couchfab = assetnewcluttermarch2022.LoadAsset<GameObject>("$custompiece_pillow2");

            var couch = new CustomPiece(couchfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "LeatherScraps", Amount = 1, Recover = true},
                        new RequirementConfig {Item = "Feathers", Amount = 1, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(couch);
        }

        private void Pillow3()
        {
            var couchfab = assetnewcluttermarch2022.LoadAsset<GameObject>("$custompiece_pillow3");

            var couch = new CustomPiece(couchfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Decor",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "LeatherScraps", Amount = 1, Recover = true},
                        new RequirementConfig {Item = "Feathers", Amount = 1, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(couch);
        }

        

     


        //kitchen

        private void FlintBowl()
        {
            var couchfab = assetnewcluttermarch2022.LoadAsset<GameObject>("$custompiece_flintbowl");

            var couch = new CustomPiece(couchfab, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_ClutterPieceTable",
                    Category = "Kitchen",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Flint", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(couch);
        }



    }
}