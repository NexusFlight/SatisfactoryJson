using System;
using System.Collections.Generic;
using System.Reflection.Metadata
using Newtonsoft.Json;

namespace SatisfactoryDataProj
{
    public partial class SatisfactoryItems
    {
        [JsonProperty("Items")]
        public List<Item> Items { get; set; }
        [JsonProperty("Buildings")]
        
        public List<Building> Buildings { get; set; }

        [JsonProperty("Phases")]
        public List<Phase> Phases { get; set; }

        [JsonProperty("Milestones")]
        public List<Milestone> Milestones { get; set; }
    }

    public partial class Phase
    {
        public Phase(string name, int phaseNumber, List<Ingredient> ingredients, List<int> tiersUnlocked)
        {
            Name = name;
            PhaseNumber = phaseNumber;
            Ingredients = ingredients;
            TiersUnlocked = tiersUnlocked;
        }
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("PhaseNumber")]
        public int PhaseNumber { get; set; }

        [JsonProperty("Ingredients")]
        public List<Ingredient> Ingredients { get; set; }

        [JsonProperty("TiersUnlocked")]
        public List<int> TiersUnlocked { get; set; }
    }
    public partial class Milestone
    {
        public Milestone(string name, int tier, List<Ingredient> ingredients, DateTime timeForReturn)
        {
            Name = name;
            Tier = tier;
            Ingredients = ingredients;
            TimeForReturn = timeForReturn;
        }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Tier")]
        public int Tier { get; set; }

        [JsonProperty("Ingredients")]
        public List<Ingredient> Ingredients { get; set; }

        [JsonProperty("TimeForReturn")]
        public DateTime TimeForReturn { get; set; }
    }

    public partial class Building
    {
        public Building(string name, string category, string subCategory, int tier, int powerUsage, List<Ingredient> ingredients, Dimensions dimensions, string unlocksAt)
        {
            Name = name;
            Category = category;
            SubCategory = subCategory;
            Tier = tier;
            PowerUsage = powerUsage;
            Ingredients = ingredients;
            Dimensions = dimensions;
            UnlocksAt = unlocksAt;
        }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Category")]
        public string Category { get; set; }

        [JsonProperty("SubCategory")]
        public string SubCategory { get; set; }

        [JsonProperty("Tier")]
        public int Tier { get; set; }

        [JsonProperty("PowerUsage")]
        public int PowerUsage { get; set; }

        [JsonProperty("Ingredients")]
        public List<Ingredient> Ingredients { get; set; }

        [JsonProperty("Dimensions")]
        public Dimensions Dimensions { get; set; }

        [JsonProperty("UnlocksAt")]
        public string UnlocksAt { get; set; }

    }

    public partial class Dimensions
    {
        public Dimensions(int width, int length, int height)
        {
            this.width = width;
            this.length = length;
            this.height = height;
        }

        [JsonProperty("Width")]
        public int width { get; set; }

        [JsonProperty("Length")]
        public int length { get; set; }

        [JsonProperty("Height")]
        public int height { get; set; }
    }

    public partial class Item
    {
        public Item(string name,string alias, List<Ingredient> ingedients, List<Ingredient> byProducts, int creates, bool reqAssembler, bool reqManufacturer, bool reqRefinery,bool isAlternate)
        {
            Name = name;
            Alias = alias;
            Ingredients = ingedients;
            ByProducts = byProducts;
            Creates = creates;
            RequiresAssembler = reqAssembler;
            RequiresManufacturer = reqManufacturer;
            RequiresRefinery = reqRefinery;
            IsAlternateRecipe = isAlternate;
        }

        [JsonProperty("Alias")]
        public string Alias { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }
        
        [JsonProperty("Building")]
        public string Building { get; set; }

        [JsonProperty("Ingedients")]
        public List<Ingredient> Ingredients { get; set; }

        [JsonProperty("ByProducts")]
        public List<Ingredient> ByProducts { get; set; }

        [JsonProperty("Creates")]
        public int Creates { get; set; }

        [JsonProperty("ProductionRate")]
        public double ProductionRate { get; set; }

        [JsonProperty("RequiresAssembler")]
        public bool RequiresAssembler { get; set; }

        [JsonProperty("RequiresManufacturer")]
        public bool RequiresManufacturer { get; set; }

        [JsonProperty("RequiresRefinery")]
        public bool RequiresRefinery { get; set; }

        [JsonProperty("IsAlternateRecipe")]
        public bool IsAlternateRecipe { get; set; }
    }

    public partial class Ingredient
    {
        public Ingredient(string itemName, int quantity)
        {
            ItemName = itemName;
            Quantity = quantity;
        }
        [JsonProperty("ItemName")]
        public string ItemName { get; set; }

        [JsonProperty("Quantity")]
        public int Quantity { get; set; }

        [JsonProperty("ProductionRate")]
        public double ProductionRate { get; set; }
    }
}
