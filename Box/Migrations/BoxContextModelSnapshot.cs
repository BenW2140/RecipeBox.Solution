﻿// <auto-generated />
using Box.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Box.Migrations
{
    [DbContext(typeof(BoxContext))]
    partial class BoxContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Box.Models.Ingredient", b =>
                {
                    b.Property<int>("IngredientId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<float>("Quantity");

                    b.HasKey("IngredientId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("Box.Models.MealType", b =>
                {
                    b.Property<int>("MealTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("MealTypeId");

                    b.ToTable("MealTypes");
                });

            modelBuilder.Entity("Box.Models.MealTypeRecipe", b =>
                {
                    b.Property<int>("MealTypeRecipeId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MealTypeId");

                    b.Property<int>("RecipeId");

                    b.HasKey("MealTypeRecipeId");

                    b.HasIndex("MealTypeId");

                    b.HasIndex("RecipeId");

                    b.ToTable("MealTypeRecipes");
                });

            modelBuilder.Entity("Box.Models.Recipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("RecDesc");

                    b.Property<string>("RecInst");

                    b.Property<string>("RecName");

                    b.Property<decimal>("RecRating");

                    b.HasKey("RecipeId");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("Box.Models.RecipeIngredient", b =>
                {
                    b.Property<int>("RecipeIngredientId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IngredientId");

                    b.Property<int>("RecipeId");

                    b.HasKey("RecipeIngredientId");

                    b.HasIndex("IngredientId");

                    b.HasIndex("RecipeId");

                    b.ToTable("RecipeIngredient");
                });

            modelBuilder.Entity("Box.Models.MealTypeRecipe", b =>
                {
                    b.HasOne("Box.Models.MealType", "MealType")
                        .WithMany("Recipes")
                        .HasForeignKey("MealTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Box.Models.Recipe", "Recipe")
                        .WithMany("MealTypes")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Box.Models.RecipeIngredient", b =>
                {
                    b.HasOne("Box.Models.Ingredient", "Ingredient")
                        .WithMany("Recipes")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Box.Models.Recipe", "Recipe")
                        .WithMany("Ingredients")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}