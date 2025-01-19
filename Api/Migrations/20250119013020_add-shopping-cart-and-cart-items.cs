using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class addshoppingcartandcartitems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Практика воздействия количественный собой работы занимаемых понимание нами.", "Грубый Меховой Компьютер", 323.86000000000001, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Анализа гражданского принимаемых не.", "Эргономичный Меховой Берет", 454.72000000000003, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Активизации участия стороны.", "Великолепный Меховой Стол", 814.62, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Обеспечение повышение курс очевидна забывать за.", "Грубый Бетонный Куртка", 821.80999999999995, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Определения организационной концепция новых организационной.", "Великолепный Деревянный Кошелек", 271.30000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Представляет всего что таким богатый повседневной равным сущности кадров.", "Потрясающий Пластиковый Стол", 781.69000000000005, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Создание принципов повышению работы принципов структуры.", "Великолепный Гранитный Носки", 81.879999999999995, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Сомнений опыт формировании.", "Фантастический Натуральный Берет", 836.65999999999997 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Кругу высокотехнологичная структуры.", "Интеллектуальный Деревянный Ножницы", 945.80999999999995, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 2", "Экономической прогресса занимаемых.", "Потрясающий Стальной Стол", 856.35000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Информационно-пропогандистское модернизации важные специалистов финансовых настолько участниками материально-технической потребностям.", "Эргономичный Деревянный Стол", 642.63, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Стороны организационной сфера понимание изменений от принимаемых настолько показывает.", "Великолепный Натуральный Автомобиль", 534.67999999999995 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Настолько играет богатый определения однако представляет поставленных значение высшего управление.", "Лоснящийся Пластиковый Куртка", 557.27999999999997, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Плановых курс повышению.", "Свободный Резиновый Автомобиль", 589.32000000000005, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Широким важную различных.", "Невероятный Стальной Свитер", 550.08000000000004 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Что ресурсосберегающих от постоянный.", "Потрясающий Хлопковый Берет", 17.18, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Однако насущным повышению за организационной базы потребностям соображения.", "Фантастический Кожанный Автомобиль", 921.26999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Дальнейшее повышению определения национальный обучения принципов оценить с же управление.", "Практичный Резиновый Стол", 168.56, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Повседневная богатый существующий формировании.", "Великолепный Стальной Автомобиль", 636.63999999999999, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Задача существующий условий поставленных вызывает эксперимент качества кадров массового сознания.", "Великолепный Бетонный Берет", 958.35000000000002, "Популярный" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Формирования специалистов ресурсосберегающих особенности укрепления внедрения.", "Фантастический Деревянный Компьютер", 289.99000000000001, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Вызывает высокотехнологичная этих финансовых предложений собой образом нашей соответствующих формированию.", "Невероятный Пластиковый Компьютер", 31.52, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Идейные выбранный социально-экономическое.", "Потрясающий Хлопковый Куртка", 588.85000000000002, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Высшего всего соображения оценить нами условий насущным курс материально-технической этих.", "Большой Неодимовый Берет", 746.39999999999998, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Для управление определения позволяет уточнения обуславливает правительством обществом выполнять.", "Маленький Пластиковый Портмоне", 486.06999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Значительной насущным систему позволяет реализация.", "Практичный Деревянный Куртка", 67.269999999999996, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Роль напрямую кругу.", "Великолепный Гранитный Свитер", 939.37, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "По организационной предложений правительством нашей идейные.", "Большой Неодимовый Стул", 693.75999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Деятельности новых соображения дальнейшее и информационно-пропогандистское.", "Лоснящийся Деревянный Ботинок", 620.03999999999996, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Новая обеспечение соответствующих процесс на опыт существующий внедрения структуры.", "Большой Неодимовый Шарф", 943.97000000000003 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Консультация управление постоянное процесс.", "Невероятный Хлопковый Майка", 693.25999999999999, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 2", "Богатый обеспечивает задания влечёт мира новая играет модели процесс.", "Великолепный Гранитный Свитер", 976.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Концепция особенности за эксперимент понимание потребностям создание.", "Практичный Деревянный Клатч", 751.37, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Демократической специалистов поставленных важную значимость.", "Свободный Меховой Майка", 346.17000000000002, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Влечёт играет что.", "Интеллектуальный Пластиковый Автомобиль", 404.75999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Сложившаяся соответствующих процесс плановых.", "Потрясающий Стальной Ботинок", 514.75999999999999, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 2", "Насущным общественной социально-экономическое модели влечёт курс образом активом занимаемых воздействия.", "Маленький Хлопковый Автомобиль", 142.33000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Систему анализа практика определения сущности занимаемых эксперимент.", "Лоснящийся Неодимовый Сабо", 223.77000000000001, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Специалистов консультация общественной высшего опыт опыт отметить по.", "Фантастический Бетонный Свитер", 922.44000000000005, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Консультация системы значимость кадровой рост повышению различных.", "Потрясающий Гранитный Шарф", 260.38, "Новинка" });
        }
    }
}
