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
    [Migration("20250121095504_Add-Order-Details-And-Order-Headers")]
    partial class AddOrderDetailsAndOrderHeaders
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

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("Api.OrderDetails", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("OrderDetailId"));

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("OrderHeaderId")
                        .HasColumnType("integer");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderHeaderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Api.OrderHeader", b =>
                {
                    b.Property<int>("OrderHeaderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("OrderHeaderId"));

                    b.Property<string>("AppUserId")
                        .HasColumnType("text");

                    b.Property<string>("CustomerEmail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("OrderDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<double>("OrderTotalAmount")
                        .HasColumnType("double precision");

                    b.Property<string>("Status")
                        .HasColumnType("text");

                    b.Property<int>("TotalCount")
                        .HasColumnType("integer");

                    b.HasKey("OrderHeaderId");

                    b.HasIndex("AppUserId");

                    b.ToTable("OrderHeaders");
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
                            Description = "Мира различных инновационный гражданского от степени.",
                            Image = "https://placehold.co/200",
                            Name = "Интеллектуальный Стальной Берет",
                            Price = 654.24000000000001,
                            SpecialTag = "Рекомендуемый"
                        },
                        new
                        {
                            Id = 2,
                            Category = "Категория 1",
                            Description = "Формированию предложений модель плановых.",
                            Image = "https://placehold.co/200",
                            Name = "Невероятный Деревянный Кепка",
                            Price = 459.75,
                            SpecialTag = "Новинка"
                        },
                        new
                        {
                            Id = 3,
                            Category = "Категория 2",
                            Description = "Разнообразный создаёт нашей же консультация показывает общества для.",
                            Image = "https://placehold.co/200",
                            Name = "Практичный Неодимовый Кошелек",
                            Price = 606.38999999999999,
                            SpecialTag = "Новинка"
                        },
                        new
                        {
                            Id = 4,
                            Category = "Категория 1",
                            Description = "Влечёт оценить показывает работы проект разнообразный.",
                            Image = "https://placehold.co/200",
                            Name = "Свободный Неодимовый Свитер",
                            Price = 52.420000000000002,
                            SpecialTag = "Популярный"
                        },
                        new
                        {
                            Id = 5,
                            Category = "Категория 3",
                            Description = "Систему целесообразности важную качества.",
                            Image = "https://placehold.co/200",
                            Name = "Лоснящийся Деревянный Кошелек",
                            Price = 334.37,
                            SpecialTag = "Рекомендуемый"
                        },
                        new
                        {
                            Id = 6,
                            Category = "Категория 1",
                            Description = "Рамки базы активизации рамки высшего однако за создание управление влечёт.",
                            Image = "https://placehold.co/200",
                            Name = "Фантастический Кожанный Автомобиль",
                            Price = 964.30999999999995,
                            SpecialTag = "Новинка"
                        },
                        new
                        {
                            Id = 7,
                            Category = "Категория 1",
                            Description = "Последовательного очевидна разработке консультация высокотехнологичная играет.",
                            Image = "https://placehold.co/200",
                            Name = "Великолепный Деревянный Носки",
                            Price = 94.680000000000007,
                            SpecialTag = "Популярный"
                        },
                        new
                        {
                            Id = 8,
                            Category = "Категория 1",
                            Description = "Нас проект анализа процесс участниками.",
                            Image = "https://placehold.co/200",
                            Name = "Интеллектуальный Стальной Ботинок",
                            Price = 72.560000000000002,
                            SpecialTag = "Новинка"
                        },
                        new
                        {
                            Id = 9,
                            Category = "Категория 2",
                            Description = "Административных поэтапного разнообразный обучения прогресса.",
                            Image = "https://placehold.co/200",
                            Name = "Эргономичный Хлопковый Автомобиль",
                            Price = 984.78999999999996,
                            SpecialTag = "Новинка"
                        },
                        new
                        {
                            Id = 10,
                            Category = "Категория 2",
                            Description = "Социально-экономическое собой обществом значительной рамки рамки демократической.",
                            Image = "https://placehold.co/200",
                            Name = "Грубый Бетонный Куртка",
                            Price = 732.72000000000003,
                            SpecialTag = "Популярный"
                        },
                        new
                        {
                            Id = 11,
                            Category = "Категория 1",
                            Description = "Инновационный финансовых целесообразности занимаемых однако работы специалистов финансовых образом.",
                            Image = "https://placehold.co/200",
                            Name = "Фантастический Деревянный Клатч",
                            Price = 902.38,
                            SpecialTag = "Рекомендуемый"
                        },
                        new
                        {
                            Id = 12,
                            Category = "Категория 2",
                            Description = "Очевидна воздействия настолько.",
                            Image = "https://placehold.co/200",
                            Name = "Потрясающий Стальной Шарф",
                            Price = 710.54999999999995,
                            SpecialTag = "Рекомендуемый"
                        },
                        new
                        {
                            Id = 13,
                            Category = "Категория 2",
                            Description = "Же место анализа важную напрямую повседневная от экономической сложившаяся условий.",
                            Image = "https://placehold.co/200",
                            Name = "Невероятный Кожанный Кошелек",
                            Price = 244.21000000000001,
                            SpecialTag = "Новинка"
                        },
                        new
                        {
                            Id = 14,
                            Category = "Категория 1",
                            Description = "Порядка количественный всего.",
                            Image = "https://placehold.co/200",
                            Name = "Интеллектуальный Пластиковый Портмоне",
                            Price = 252.19,
                            SpecialTag = "Популярный"
                        },
                        new
                        {
                            Id = 15,
                            Category = "Категория 2",
                            Description = "Принципов активизации уточнения прогресса базы повышение управление.",
                            Image = "https://placehold.co/200",
                            Name = "Лоснящийся Хлопковый Плащ",
                            Price = 335.54000000000002,
                            SpecialTag = "Новинка"
                        },
                        new
                        {
                            Id = 16,
                            Category = "Категория 1",
                            Description = "Потребностям структура прежде позиции обуславливает эксперимент.",
                            Image = "https://placehold.co/200",
                            Name = "Великолепный Хлопковый Свитер",
                            Price = 17.059999999999999,
                            SpecialTag = "Рекомендуемый"
                        },
                        new
                        {
                            Id = 17,
                            Category = "Категория 3",
                            Description = "Инновационный стороны способствует специалистов потребностям активизации а изменений требует представляет.",
                            Image = "https://placehold.co/200",
                            Name = "Практичный Гранитный Майка",
                            Price = 995.10000000000002,
                            SpecialTag = "Рекомендуемый"
                        },
                        new
                        {
                            Id = 18,
                            Category = "Категория 3",
                            Description = "Представляет проект не занимаемых проверки показывает управление формирования современного административных.",
                            Image = "https://placehold.co/200",
                            Name = "Грубый Пластиковый Клатч",
                            Price = 541.28999999999996,
                            SpecialTag = "Новинка"
                        },
                        new
                        {
                            Id = 19,
                            Category = "Категория 1",
                            Description = "От представляет задача организации изменений роль организационной.",
                            Image = "https://placehold.co/200",
                            Name = "Эргономичный Деревянный Ботинок",
                            Price = 516.32000000000005,
                            SpecialTag = "Популярный"
                        },
                        new
                        {
                            Id = 20,
                            Category = "Категория 3",
                            Description = "И от что позволяет специалистов идейные социально-ориентированный специалистов что.",
                            Image = "https://placehold.co/200",
                            Name = "Фантастический Бетонный Автомобиль",
                            Price = 543.5,
                            SpecialTag = "Рекомендуемый"
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
                        .WithMany("CartItems")
                        .HasForeignKey("ShoppingCartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Api.OrderDetails", b =>
                {
                    b.HasOne("Api.OrderHeader", null)
                        .WithMany("OrderDetailItems")
                        .HasForeignKey("OrderHeaderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Api.OrderHeader", b =>
                {
                    b.HasOne("Api.AppUser", "User")
                        .WithMany()
                        .HasForeignKey("AppUserId");

                    b.Navigation("User");
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

            modelBuilder.Entity("Api.OrderHeader", b =>
                {
                    b.Navigation("OrderDetailItems");
                });

            modelBuilder.Entity("Api.ShoppingCart", b =>
                {
                    b.Navigation("CartItems");
                });
#pragma warning restore 612, 618
        }
    }
}
