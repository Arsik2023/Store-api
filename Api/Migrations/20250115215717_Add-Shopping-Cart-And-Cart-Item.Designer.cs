﻿// <auto-generated />
using System;
using Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250115215717_Add-Shopping-Cart-And-Cart-Item")]
    partial class AddShoppingCartAndCartItem
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Api.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<int>("ShoppingCartId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("ShoppingCartId");

                    b.ToTable("CartItem");
                });

            modelBuilder.Entity("Api.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<string>("SpecialTag")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Категория 2",
                            Description = "Формирования специалистов ресурсосберегающих особенности укрепления внедрения.",
                            Image = "https://placehold.co/200",
                            Name = "Фантастический Деревянный Компьютер",
                            Price = 289.99000000000001,
                            SpecialTag = "Рекомендуемый"
                        },
                        new
                        {
                            Id = 2,
                            Category = "Категория 3",
                            Description = "Вызывает высокотехнологичная этих финансовых предложений собой образом нашей соответствующих формированию.",
                            Image = "https://placehold.co/200",
                            Name = "Невероятный Пластиковый Компьютер",
                            Price = 31.52,
                            SpecialTag = "Рекомендуемый"
                        },
                        new
                        {
                            Id = 3,
                            Category = "Категория 2",
                            Description = "Идейные выбранный социально-экономическое.",
                            Image = "https://placehold.co/200",
                            Name = "Потрясающий Хлопковый Куртка",
                            Price = 588.85000000000002,
                            SpecialTag = "Рекомендуемый"
                        },
                        new
                        {
                            Id = 4,
                            Category = "Категория 2",
                            Description = "Высшего всего соображения оценить нами условий насущным курс материально-технической этих.",
                            Image = "https://placehold.co/200",
                            Name = "Большой Неодимовый Берет",
                            Price = 746.39999999999998,
                            SpecialTag = "Новинка"
                        },
                        new
                        {
                            Id = 5,
                            Category = "Категория 3",
                            Description = "Для управление определения позволяет уточнения обуславливает правительством обществом выполнять.",
                            Image = "https://placehold.co/200",
                            Name = "Маленький Пластиковый Портмоне",
                            Price = 486.06999999999999,
                            SpecialTag = "Новинка"
                        },
                        new
                        {
                            Id = 6,
                            Category = "Категория 2",
                            Description = "Значительной насущным систему позволяет реализация.",
                            Image = "https://placehold.co/200",
                            Name = "Практичный Деревянный Куртка",
                            Price = 67.269999999999996,
                            SpecialTag = "Рекомендуемый"
                        },
                        new
                        {
                            Id = 7,
                            Category = "Категория 2",
                            Description = "Роль напрямую кругу.",
                            Image = "https://placehold.co/200",
                            Name = "Великолепный Гранитный Свитер",
                            Price = 939.37,
                            SpecialTag = "Популярный"
                        },
                        new
                        {
                            Id = 8,
                            Category = "Категория 1",
                            Description = "По организационной предложений правительством нашей идейные.",
                            Image = "https://placehold.co/200",
                            Name = "Большой Неодимовый Стул",
                            Price = 693.75999999999999,
                            SpecialTag = "Популярный"
                        },
                        new
                        {
                            Id = 9,
                            Category = "Категория 1",
                            Description = "Деятельности новых соображения дальнейшее и информационно-пропогандистское.",
                            Image = "https://placehold.co/200",
                            Name = "Лоснящийся Деревянный Ботинок",
                            Price = 620.03999999999996,
                            SpecialTag = "Новинка"
                        },
                        new
                        {
                            Id = 10,
                            Category = "Категория 1",
                            Description = "Новая обеспечение соответствующих процесс на опыт существующий внедрения структуры.",
                            Image = "https://placehold.co/200",
                            Name = "Большой Неодимовый Шарф",
                            Price = 943.97000000000003,
                            SpecialTag = "Популярный"
                        },
                        new
                        {
                            Id = 11,
                            Category = "Категория 1",
                            Description = "Консультация управление постоянное процесс.",
                            Image = "https://placehold.co/200",
                            Name = "Невероятный Хлопковый Майка",
                            Price = 693.25999999999999,
                            SpecialTag = "Новинка"
                        },
                        new
                        {
                            Id = 12,
                            Category = "Категория 2",
                            Description = "Богатый обеспечивает задания влечёт мира новая играет модели процесс.",
                            Image = "https://placehold.co/200",
                            Name = "Великолепный Гранитный Свитер",
                            Price = 976.0,
                            SpecialTag = "Рекомендуемый"
                        },
                        new
                        {
                            Id = 13,
                            Category = "Категория 2",
                            Description = "Концепция особенности за эксперимент понимание потребностям создание.",
                            Image = "https://placehold.co/200",
                            Name = "Практичный Деревянный Клатч",
                            Price = 751.37,
                            SpecialTag = "Рекомендуемый"
                        },
                        new
                        {
                            Id = 14,
                            Category = "Категория 3",
                            Description = "Демократической специалистов поставленных важную значимость.",
                            Image = "https://placehold.co/200",
                            Name = "Свободный Меховой Майка",
                            Price = 346.17000000000002,
                            SpecialTag = "Новинка"
                        },
                        new
                        {
                            Id = 15,
                            Category = "Категория 1",
                            Description = "Влечёт играет что.",
                            Image = "https://placehold.co/200",
                            Name = "Интеллектуальный Пластиковый Автомобиль",
                            Price = 404.75999999999999,
                            SpecialTag = "Рекомендуемый"
                        },
                        new
                        {
                            Id = 16,
                            Category = "Категория 2",
                            Description = "Сложившаяся соответствующих процесс плановых.",
                            Image = "https://placehold.co/200",
                            Name = "Потрясающий Стальной Ботинок",
                            Price = 514.75999999999999,
                            SpecialTag = "Рекомендуемый"
                        },
                        new
                        {
                            Id = 17,
                            Category = "Категория 2",
                            Description = "Насущным общественной социально-экономическое модели влечёт курс образом активом занимаемых воздействия.",
                            Image = "https://placehold.co/200",
                            Name = "Маленький Хлопковый Автомобиль",
                            Price = 142.33000000000001,
                            SpecialTag = "Рекомендуемый"
                        },
                        new
                        {
                            Id = 18,
                            Category = "Категория 3",
                            Description = "Систему анализа практика определения сущности занимаемых эксперимент.",
                            Image = "https://placehold.co/200",
                            Name = "Лоснящийся Неодимовый Сабо",
                            Price = 223.77000000000001,
                            SpecialTag = "Новинка"
                        },
                        new
                        {
                            Id = 19,
                            Category = "Категория 3",
                            Description = "Специалистов консультация общественной высшего опыт опыт отметить по.",
                            Image = "https://placehold.co/200",
                            Name = "Фантастический Бетонный Свитер",
                            Price = 922.44000000000005,
                            SpecialTag = "Рекомендуемый"
                        },
                        new
                        {
                            Id = 20,
                            Category = "Категория 1",
                            Description = "Консультация системы значимость кадровой рост повышению различных.",
                            Image = "https://placehold.co/200",
                            Name = "Потрясающий Гранитный Шарф",
                            Price = 260.38,
                            SpecialTag = "Новинка"
                        });
                });

            modelBuilder.Entity("Api.ShoppingCart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ShoppingCart");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("character varying(13)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator().HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Api.AppUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.HasDiscriminator().HasValue("AppUser");
                });

            modelBuilder.Entity("Api.CartItem", b =>
                {
                    b.HasOne("Api.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api.ShoppingCart", null)
                        .WithMany("CartItem")
                        .HasForeignKey("ShoppingCartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Api.ShoppingCart", b =>
                {
                    b.Navigation("CartItem");
                });
#pragma warning restore 612, 618
        }
    }
}
