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

namespace Clutter
{
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    [BepInDependency(Jotunn.Main.ModGuid)]
    internal class Clutter : BaseUnityPlugin
    {
        public const string PluginGUID = "com.plumga.Clutter";
        public const string PluginName = "Clutter";
        public const string PluginVersion = "0.0.6";
        private AssetBundle assetclutter;
        private AssetBundle assetdeco;
        private AssetBundle assetfurniture;
        private AssetBundle assetkitchen;
        private AssetBundle assetsculptures;





        private void Awake()
        {

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
            //tables
            roundtable();
            tablewithcloth();
            //chests
            fancychest();
            stonechest();
            //shelves
            shelf();
            shelfwbooks();
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
            plate();
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

          
        }


        private void LoadAssets()
        {
            assetclutter = AssetUtils.LoadAssetBundleFromResources("clutter", typeof(Clutter).Assembly);
            assetdeco = AssetUtils.LoadAssetBundleFromResources("deco", typeof(Clutter).Assembly);
            assetfurniture = AssetUtils.LoadAssetBundleFromResources("furniture", typeof(Clutter).Assembly);
            assetkitchen = AssetUtils.LoadAssetBundleFromResources("kitchen", typeof(Clutter).Assembly);
            assetsculptures = AssetUtils.LoadAssetBundleFromResources("sculptures", typeof(Clutter).Assembly);

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
                        new RequirementConfig { Item = "Wood", Amount = 2}
                    }
                });
            ItemManager.Instance.AddItem(ctool);

        }


        /////deco
        //buckets
        private void basket()
        {
            var basketfab = assetdeco.LoadAsset<GameObject>("$custompiece_basket");

            var basket = new CustomPiece(basketfab,
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

            var decobucket = new CustomPiece(decobucketfab,
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

            var decobucketbig = new CustomPiece(decobucketbigfab,
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

            var candleb = new CustomPiece(candlebfab,
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

            var candlel = new CustomPiece(candlelfab,
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

            var candlelit2 = new CustomPiece(candlelit2fab,
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

            var candles = new CustomPiece(candlesfab,
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

            var candle = new CustomPiece(candlefab,
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

            var candlelit = new CustomPiece(candlelitfab,
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

            var diary = new CustomPiece(diaryfab,
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

            var diaryp = new CustomPiece(diarypfab,
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

            var bookblue = new CustomPiece(bookbluefab,
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

            var bookblueh = new CustomPiece(bookbluehfab,
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

            var bookred = new CustomPiece(bookredfab,
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

            var bookredh = new CustomPiece(bookredhfab,
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

            var qi = new CustomPiece(qifab,
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

            var qp = new CustomPiece(qpfab,
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

            var scroll = new CustomPiece(scrollfab,
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

            var scroll2 = new CustomPiece(scroll2fab,
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

            var scroll3 = new CustomPiece(scroll3fab,
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

            var scroll4 = new CustomPiece(scroll4fab,
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

            var scroll5 = new CustomPiece(scroll5fab,
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

            var pf1 = new CustomPiece(pf1fab,
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

            var pf2 = new CustomPiece(pf2fab,
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

            var pf3 = new CustomPiece(pf3fab,
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

            var pf4 = new CustomPiece(pf4fab,
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

            var deer = new CustomPiece(deerfab,
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

            var lox = new CustomPiece(loxfab,
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

            var wolf = new CustomPiece(wolffab,
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

            var soap = new CustomPiece(soapfab,
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

            var pipe = new CustomPiece(pipefab,
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

            var comb = new CustomPiece(combfab,
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

            var straw = new CustomPiece(strawfab,
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

            var winebottle = new CustomPiece(winebottlefab,
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

            var bp = new CustomPiece(bpfab,
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

            var grave = new CustomPiece(gravefab,
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

            var bonepile = new CustomPiece(bonepilefab,
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

            var bones1 = new CustomPiece(bones1fab,
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

            var bones2 = new CustomPiece(bones2fab,
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

            var bones3 = new CustomPiece(bones3fab,
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

            var bones4 = new CustomPiece(bones4fab,
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

            var skull = new CustomPiece(skullfab,
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

            var standh = new CustomPiece(standhfab,
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

            var standv = new CustomPiece(standvfab,
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

            var standsp = new CustomPiece(standspfab,
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

            var standst = new CustomPiece(standstfab,
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

            var coolchair = new CustomPiece(coolchairfab,
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
            var stoolfab = assetfurniture.LoadAsset<GameObject>("$custompiece_stool");

            var stool = new CustomPiece(stoolfab,
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

            var swing = new CustomPiece(swingfab,
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


        //chairs
        private void roundtable()
        {
            var roundtablefab = assetfurniture.LoadAsset<GameObject>("$custompiece_roundtable");

            var roundtable = new CustomPiece(roundtablefab,
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
            var clothtablefab = assetfurniture.LoadAsset<GameObject>("$custompiece_roundtablewithcloth");

            var clothtable = new CustomPiece(clothtablefab,
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

            var chest2 = new CustomPiece(chest2fab,
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

            var chest1 = new CustomPiece(chest1fab,
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

            var shelf = new CustomPiece(shelffab,
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

            var bookshelf = new CustomPiece(bookshelffab,
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

        private void weaponrack()
        {
            var weaponrackfab = assetfurniture.LoadAsset<GameObject>("$custompiece_weaponrack");

            var weaponrack = new CustomPiece(weaponrackfab,
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

            var weaponrackfull = new CustomPiece(weaponrackfullfab,
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

            var altar = new CustomPiece(altarfab,
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

            var altarcandle = new CustomPiece(altarcandlefab,
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

            var tub = new CustomPiece(tubfab,
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

            var tubfull = new CustomPiece(tubfullfab,
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

            var winerack = new CustomPiece(winerackfab,
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

            var clock = new CustomPiece(clockfab,
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

            var birdhouse = new CustomPiece(birdhousefab,
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

            var bowl = new CustomPiece(bowlfab,
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




        private void plate()
        {
            var platefab = assetkitchen.LoadAsset<GameObject>("$custompiece_dunmr_plate");

            var plate = new CustomPiece(platefab,
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

        //mugs
        private void mug1()
        {
            var mug1fab = assetkitchen.LoadAsset<GameObject>("$custompiece_dunmr_mug1");

            var mug = new CustomPiece(mug1fab,
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

            var mug2 = new CustomPiece(mug2fab,
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

            var pan = new CustomPiece(panfab,
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

            var pot = new CustomPiece(potfab,
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

            var spoon = new CustomPiece(spoonfab,
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

            var mortarpestle = new CustomPiece(mortarpestlefab,
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

            var rollingpin = new CustomPiece(rollingpinfab,
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

            var fondue = new CustomPiece(fonduefab,
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

            var picnicbasket = new CustomPiece(picnicbasketfab,
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
                                                                                          
            var owl = new CustomPiece(owlfab,
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

            var pelican = new CustomPiece(pelicanfab,
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

            var deer = new CustomPiece(deerfab,
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

            var elk = new CustomPiece(elkfab,
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

            var crow = new CustomPiece(crowfab,
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

            var heron = new CustomPiece(heronfab,
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

            var horse = new CustomPiece(horsefab,
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

            var wolf = new CustomPiece(wolffab,
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

            var corgi = new CustomPiece(corgifab,
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

            var statuedeer = new CustomPiece(statuedeerfab,
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

            var statueevill = new CustomPiece(statueevillfab,
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

            var statueevils = new CustomPiece(statueevilsfab,
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

            var statuehare = new CustomPiece(statueharefab,
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

            var statueseed = new CustomPiece(statueseedfab,
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


      


    }
}