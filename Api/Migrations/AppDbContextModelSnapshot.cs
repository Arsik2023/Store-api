﻿// <auto-generated />
using System;
using Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.ToTable("CartItems");
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
                            Category = "Категория 3",
                            Description = "Условий сфера степени количественный роль.",
                            Image = "https://placehold.co/200",
                            Name = "Большой Неодимовый Ножницы",
                            Price = 625.14999999999998,
                            SpecialTag = "Популярный"
                        },
                        new
                        {
                            Id = 2,
                            Category = "Категория 3",
                            Description = "Концепция количественный национальный нами повседневной мира нас.",
                            Image = "https://placehold.co/200",
                            Name = "Лоснящийся Стальной Портмоне",
                            Price = 442.72000000000003,
                            SpecialTag = "Популярный"
                        },
                        new
                        {
                            Id = 3,
                            Category = "Категория 3",
                            Description = "Участниками оценить в.",
                            Image = "https://placehold.co/200",
                            Name = "Практичный Натуральный Кулон",
                            Price = 990.13,
                            SpecialTag = "Рекомендуемый"
                        },
                        new
                        {
                            Id = 4,
                            Category = "Категория 1",
                            Description = "Управление задач позволяет богатый напрямую массового отношении интересный для.",
                            Image = "https://placehold.co/200",
                            Name = "Маленький Гранитный Автомобиль",
                            Price = 42.159999999999997,
                            SpecialTag = "Новинка"
                        },
                        new
                        {
                            Id = 5,
                            Category = "Категория 3",
                            Description = "Дальнейшее насущным играет задания гражданского прежде постоянный материально-технической рамки.",
                            Image = "https://placehold.co/200",
                            Name = "Эргономичный Гранитный Стул",
                            Price = 582.61000000000001,
                            SpecialTag = "Новинка"
                        },
                        new
                        {
                            Id = 6,
                            Category = "Категория 3",
                            Description = "Очевидна выполнять забывать в рост повышению от.",
                            Image = "https://placehold.co/200",
                            Name = "Потрясающий Меховой Кулон",
                            Price = 765.35000000000002,
                            SpecialTag = "Новинка"
                        },
                        new
                        {
                            Id = 7,
                            Category = "Категория 3",
                            Description = "Поэтапного значительной специалистов значимость социально-экономическое всего.",
                            Image = "https://placehold.co/200",
                            Name = "Невероятный Пластиковый Компьютер",
                            Price = 284.67000000000002,
                            SpecialTag = "Новинка"
                        },
                        new
                        {
                            Id = 8,
                            Category = "Категория 1",
                            Description = "Участниками качества дальнейшее систему а потребностям с за следует что.",
                            Image = "https://placehold.co/200",
                            Name = "Фантастический Деревянный Сабо",
                            Price = 589.09000000000003,
                            SpecialTag = "Популярный"
                        },
                        new
                        {
                            Id = 9,
                            Category = "Категория 2",
                            Description = "Активизации последовательного на гражданского другой.",
                            Image = "https://placehold.co/200",
                            Name = "Великолепный Бетонный Плащ",
                            Price = 343.68000000000001,
                            SpecialTag = "Новинка"
                        },
                        new
                        {
                            Id = 10,
                            Category = "Категория 1",
                            Description = "Финансовых управление и внедрения сознания напрямую соответствующей.",
                            Image = "https://placehold.co/200",
                            Name = "Невероятный Деревянный Кулон",
                            Price = 812.34000000000003,
                            SpecialTag = "Рекомендуемый"
                        },
                        new
                        {
                            Id = 11,
                            Category = "Категория 2",
                            Description = "Прогресса богатый обществом понимание что.",
                            Image = "https://placehold.co/200",
                            Name = "Грубый Хлопковый Компьютер",
                            Price = 268.45999999999998,
                            SpecialTag = "Популярный"
                        },
                        new
                        {
                            Id = 12,
                            Category = "Категория 2",
                            Description = "Настолько также социально-ориентированный разнообразный для напрямую поставленных создаёт.",
                            Image = "https://placehold.co/200",
                            Name = "Великолепный Меховой Стул",
                            Price = 917.19000000000005,
                            SpecialTag = "Популярный"
                        },
                        new
                        {
                            Id = 13,
                            Category = "Категория 1",
                            Description = "Предпосылки разработке играет широким инновационный потребностям поэтапного место.",
                            Image = "https://placehold.co/200",
                            Name = "Фантастический Кожанный Кошелек",
                            Price = 592.67999999999995,
                            SpecialTag = "Новинка"
                        },
                        new
                        {
                            Id = 14,
                            Category = "Категория 1",
                            Description = "А современного настолько проблем структура дальнейшее очевидна опыт.",
                            Image = "https://placehold.co/200",
                            Name = "Потрясающий Бетонный Компьютер",
                            Price = 741.55999999999995,
                            SpecialTag = "Популярный"
                        },
                        new
                        {
                            Id = 15,
                            Category = "Категория 2",
                            Description = "Практика системы же ресурсосберегающих.",
                            Image = "https://placehold.co/200",
                            Name = "Интеллектуальный Гранитный Плащ",
                            Price = 2.27,
                            SpecialTag = "Новинка"
                        },
                        new
                        {
                            Id = 16,
                            Category = "Категория 1",
                            Description = "Деятельности разработке важную нашей дальнейших создаёт.",
                            Image = "https://placehold.co/200",
                            Name = "Интеллектуальный Хлопковый Портмоне",
                            Price = 872.34000000000003,
                            SpecialTag = "Новинка"
                        },
                        new
                        {
                            Id = 17,
                            Category = "Категория 1",
                            Description = "Принципов анализа мира.",
                            Image = "https://placehold.co/200",
                            Name = "Практичный Деревянный Носки",
                            Price = 241.08000000000001,
                            SpecialTag = "Рекомендуемый"
                        },
                        new
                        {
                            Id = 18,
                            Category = "Категория 1",
                            Description = "Направлений последовательного забывать способствует.",
                            Image = "https://placehold.co/200",
                            Name = "Практичный Гранитный Стол",
                            Price = 493.19999999999999,
                            SpecialTag = "Новинка"
                        },
                        new
                        {
                            Id = 19,
                            Category = "Категория 2",
                            Description = "Задач следует мира начало воздействия практика.",
                            Image = "https://placehold.co/200",
                            Name = "Потрясающий Неодимовый Плащ",
                            Price = 583.84000000000003,
                            SpecialTag = "Рекомендуемый"
                        },
                        new
                        {
                            Id = 20,
                            Category = "Категория 1",
                            Description = "Однако показывает что.",
                            Image = "https://placehold.co/200",
                            Name = "Лоснящийся Меховой Компьютер",
                            Price = 127.43000000000001,
                            SpecialTag = "Популярный"
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

                    b.ToTable("ShoppingCarts");
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
