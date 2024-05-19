using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTycoonLibrary.Classes
{
    public static class AssetsBank
    {
        public static List<Item> Items;
        public static List<Recipe> Recipes;
        public static List<Factory> Factories;
        
        static AssetsBank()
        {
            Items = new List<Item>();
            Recipes = new List<Recipe>();
            Factories = new List<Factory>();
            PopulateItems();
            PopulateRecipes();
            PopulateFactories();
        }

        public static void PopulateItems()
        {
            Items.Add(new Item((int)ITEM_ID.IRON_ORE, "Iron ore", 50, "An ore made from iron. Can be mined with the miners."));
            Items.Add(new Item((int)ITEM_ID.IRON_INGOT, "Iron ingot", 100, "A basic ingot used for every iron items. Made from iron ores with the smelters."));
            Items.Add(new Item((int)ITEM_ID.IRON_ROD, "Iron rod", 300, "A basic iron item, mainly used for almost every foundation frames."));
            Items.Add(new Item((int)ITEM_ID.IRON_PLATE, "Iron plate", 500, "Used for floorings, can also be used with rods as well."));
            Items.Add(new Item((int)ITEM_ID.IRON_BOLT, "Iron bolt", 50, "The main item for frames concretion."));
            Items.Add(new Item((int)ITEM_ID.IRON_FRAME, "Iron frame", 3000, "A basic frame for every iron foundations."));
            Items.Add(new Item((int)ITEM_ID.IRON_BOLTED_PLATE, "Iron bolted plate", 2650, "Two frames bolted if bolts. Increases toughness and durability, it is used in advance iron technology."));
            Items.Add(new Item((int)ITEM_ID.IRON_BLADE, "Iron blade", 6300, "A single blade made from simple iron components. Simple enough to slice a slime."));
            Items.Add(new Item((int)ITEM_ID.IRON_BOX, "Iron box", 15000, "A strong and durable box. Usually used as storage."));
            Items.Add(new Item((int)ITEM_ID.IRON_SWORD, "Iron sword", 15000, "A real sword made from iron. Now upgraded to slice more slimes."));
        }

        public static void PopulateRecipes()
        {
            RecipeItem[] r1 = { };
            RecipeItem p1 = new RecipeItem(FindItemByID((int)ITEM_ID.IRON_ORE), 2);
            Recipes.Add(new Recipe((int)RECIPE_ID.IRON_ORE, "Iron ore", r1.ToList(), p1, "Main iron ore recipe."));

            RecipeItem r2_1 = new RecipeItem(FindItemByID((int)ITEM_ID.IRON_ORE), 1);
            RecipeItem[] r2 = { r2_1 };
            RecipeItem p2 = new RecipeItem(FindItemByID((int)ITEM_ID.IRON_INGOT), 1);
            Recipes.Add(new Recipe((int)RECIPE_ID.IRON_INGOT, "Iron ingot", r2.ToList(), p2, "Main iron ingot recipe."));

            RecipeItem r3_1 = new RecipeItem(FindItemByID((int)ITEM_ID.IRON_INGOT), 2);
            RecipeItem[] r3 = { r3_1 };
            RecipeItem p3 = new RecipeItem(FindItemByID((int)ITEM_ID.IRON_ROD), 1);
            Recipes.Add(new Recipe((int)RECIPE_ID.IRON_ROD, "Iron rod", r3.ToList(), p3, "Main iron rod recipe."));

            RecipeItem r4_1 = new RecipeItem(FindItemByID((int)ITEM_ID.IRON_INGOT), 3);
            RecipeItem[] r4 = { r4_1 };
            RecipeItem p4 = new RecipeItem(FindItemByID((int)ITEM_ID.IRON_PLATE), 1);
            Recipes.Add(new Recipe((int)RECIPE_ID.IRON_PLATE, "Iron plate", r4.ToList(), p4, "Main iron plate recipe."));

            RecipeItem r5_1 = new RecipeItem(FindItemByID((int)ITEM_ID.IRON_ROD), 3);
            RecipeItem[] r5 = { r5_1 };
            RecipeItem p5 = new RecipeItem(FindItemByID((int)ITEM_ID.IRON_BOLT), 20);
            Recipes.Add(new Recipe((int)RECIPE_ID.IRON_BOLT, "Iron bolt", r5.ToList(), p5, "Main iron bolt recipe."));

            RecipeItem r6_1 = new RecipeItem(FindItemByID((int)ITEM_ID.IRON_ROD), 4);
            RecipeItem r6_2 = new RecipeItem(FindItemByID((int)ITEM_ID.IRON_BOLT), 25);
            RecipeItem[] r6 = { r6_1, r6_2 };
            RecipeItem p6 = new RecipeItem(FindItemByID((int)ITEM_ID.IRON_FRAME), 1);
            Recipes.Add(new Recipe((int)RECIPE_ID.IRON_FRAME, "Iron frame", r6.ToList(), p6, "Main iron frame recipe."));

            RecipeItem r7_1 = new RecipeItem(FindItemByID((int)ITEM_ID.IRON_PLATE), 2);
            RecipeItem r7_2 = new RecipeItem(FindItemByID((int)ITEM_ID.IRON_BOLT), 12);
            RecipeItem[] r7 = { r7_1, r7_2 };
            RecipeItem p7 = new RecipeItem(FindItemByID((int)ITEM_ID.IRON_BOLTED_PLATE), 1);
            Recipes.Add(new Recipe((int)RECIPE_ID.IRON_BOLTED_PLATE, "Iron bolted plate", r7.ToList(), p7, "Main iron bolted plate recipe."));

            RecipeItem r8_1 = new RecipeItem(FindItemByID((int)ITEM_ID.IRON_PLATE), 3);
            RecipeItem r8_2 = new RecipeItem(FindItemByID((int)ITEM_ID.IRON_BOLTED_PLATE), 2);
            RecipeItem[] r8 = { r8_1, r8_2 };
            RecipeItem p8 = new RecipeItem(FindItemByID((int)ITEM_ID.IRON_BLADE), 1);
            Recipes.Add(new Recipe((int)RECIPE_ID.IRON_BLADE, "Iron blade", r8.ToList(), p8, "Main iron blade recipe."));

            RecipeItem r9_1 = new RecipeItem(FindItemByID((int)ITEM_ID.IRON_FRAME), 2);
            RecipeItem r9_2 = new RecipeItem(FindItemByID((int)ITEM_ID.IRON_BOLTED_PLATE), 7);
            RecipeItem r9_3 = new RecipeItem(FindItemByID((int)ITEM_ID.IRON_ROD), 2);
            RecipeItem r9_4 = new RecipeItem(FindItemByID((int)ITEM_ID.IRON_BOLT), 20);
            RecipeItem[] r9 = { r9_1, r9_2, r9_3, r9_4 };
            RecipeItem p9 = new RecipeItem(FindItemByID((int)ITEM_ID.IRON_BOX), 2);
            Recipes.Add(new Recipe((int)RECIPE_ID.IRON_BOX, "Iron box", r9.ToList(), p9, "Main iron box recipe."));

            RecipeItem r10_1 = new RecipeItem(FindItemByID((int)ITEM_ID.IRON_BLADE), 1);
            RecipeItem r10_2 = new RecipeItem(FindItemByID((int)ITEM_ID.IRON_ROD), 2);
            RecipeItem r10_3 = new RecipeItem(FindItemByID((int)ITEM_ID.IRON_BOLTED_PLATE), 2);
            RecipeItem r10_4 = new RecipeItem(FindItemByID((int)ITEM_ID.IRON_INGOT), 3);
            RecipeItem[] r10 = { r10_1, r10_2, r10_3, r10_4 };
            RecipeItem p10 = new RecipeItem(FindItemByID((int)ITEM_ID.IRON_SWORD), 1);
            Recipes.Add(new Recipe((int)RECIPE_ID.IRON_SWORD, "Iron sword", r10.ToList(), p10, "Main iron sword recipe."));
        }
/*
        private static List<RecipeItem> ConvertArrayOfRIToList(RecipeItem[] items)
        {
            return items.ToList();
        }*/

        public static void PopulateFactories()
        {
            int[] miner_recipes = { (int)RECIPE_ID.IRON_ORE };
            Factories.Add(new Factory((int)FACTORY_ID.MINER, "Miner", 500, GetRecipesForFactory(miner_recipes), "Basic miner for every resources."));
            int[] smelter_recipes = { (int)RECIPE_ID.IRON_INGOT };
            Factories.Add(new Factory((int)FACTORY_ID.SMELTER, "Smelter", 1000, GetRecipesForFactory(smelter_recipes), "Basic smelter for every ores."));
            int[] constructor_recipes = { (int)RECIPE_ID.IRON_ROD, (int)RECIPE_ID.IRON_PLATE, (int)RECIPE_ID.IRON_BOLT };
            Factories.Add(new Factory((int)FACTORY_ID.CONSTRUCTOR, "Constructor", 3500, GetRecipesForFactory(constructor_recipes), "Used to create simple components."));
            int[] assembler_recipes = { (int)RECIPE_ID.IRON_FRAME, (int)RECIPE_ID.IRON_BOLTED_PLATE, (int)RECIPE_ID.IRON_BLADE };
            Factories.Add(new Factory((int)FACTORY_ID.ASSEMBLER, "Assembler", 10000, GetRecipesForFactory(assembler_recipes), "Now has 2 input slots. Mainly crafting advanced components."));
            int[] manufacturer_recipes = { (int)RECIPE_ID.IRON_BOX, (int)RECIPE_ID.IRON_SWORD };
            Factories.Add(new Factory((int)FACTORY_ID.MANUFACTURER, "Manufacturer", 18000, GetRecipesForFactory(manufacturer_recipes), "The most advanced factory. Used in mega productions."));
        }

        private static List<Recipe> GetRecipesForFactory(int[] recipe_ids)
        {
            List<Recipe> recipes = new List<Recipe>();
            foreach(int id in recipe_ids)
            {
                recipes.Add(FindRecipeByID(id));
            }
            return recipes;
        }

        public static Item FindItemByID(int id)
        {
            return Items.SingleOrDefault(x => x.ID == id);
        }

        public static Recipe FindRecipeByID(int id)
        {
            return Recipes.SingleOrDefault(x => x.ID == id);
        }

        public static Recipe FindRecipeByName(string name)
        {
            return Recipes.SingleOrDefault(x => x.Name == name);
        }

        public static Factory FindFactoryByID(int id)
        {
            return Factories.SingleOrDefault(x => x.ID == id);
        }
    }
}
