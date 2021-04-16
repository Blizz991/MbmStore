using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MbmStore.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Book_Publisher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Director = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Artist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalTime = table.Column<TimeSpan>(type: "time", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Invoice",
                columns: table => new
                {
                    InvoiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => x.InvoiceId);
                    table.ForeignKey(
                        name: "FK_Invoice_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Phone",
                columns: table => new
                {
                    PhoneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    PhoneType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phone", x => x.PhoneId);
                    table.ForeignKey(
                        name: "FK_Phone_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Track",
                columns: table => new
                {
                    TrackId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Composer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Length = table.Column<TimeSpan>(type: "time", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    MusicCDProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Track", x => x.TrackId);
                    table.ForeignKey(
                        name: "FK_Track_Product_MusicCDProductId",
                        column: x => x.MusicCDProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    OrderItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    InvoiceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.OrderItemId);
                    table.ForeignKey(
                        name: "FK_OrderItem_Invoice_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoice",
                        principalColumn: "InvoiceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItem_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerId", "Address", "BirthDate", "City", "FirstName", "LastName", "ZipCode" },
                values: new object[,]
                {
                    { 1, " Naturvej 22", new DateTime(1991, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselager", "Lasse", "Olsen", 8361 },
                    { 2, "Danskgade 23", new DateTime(1957, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aarhus", "Mikkel", "Viadith", 8000 },
                    { 3, "Violvej 121", new DateTime(1965, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aarhus", "Oscar", "Lacour", 800 },
                    { 4, "Slotsgade", new DateTime(1911, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aarhus", "Bente", "Hansen", 8000 },
                    { 5, "Bavnestraede 221", new DateTime(1945, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aarhus", "Viola", "Fisker", 8000 },
                    { 6, "Toften 69 ", new DateTime(2010, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselager", "Trine", "Jakobsen", 8361 },
                    { 7, "Solbakkevej 6 ", new DateTime(2000, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Viby J ", "Mads", "Kristiansen", 8260 },
                    { 8, "Solvangsvej 12", new DateTime(1985, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Viby J ", "Ole", "Sorensen", 8260 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Author", "Category", "Discriminator", "ISBN", "ImageFileName", "Price", "Book_Publisher", "Title" },
                values: new object[] { 1, "Steve Turner", "Book", "Book", "6214241", "hardDaysWrite.jpg", 150.00m, "HarperCollins Publishers", "A Hard Day's Write: The Stories Behind Every Beatles Song" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Artist", "Category", "Discriminator", "ImageFileName", "Label", "Price", "Publisher", "Title", "TotalTime" },
                values: new object[,]
                {
                    { 4, "Stuff", "MusicCD", "MusicCD", "gladiator.jpg", "That Label", 1289.00m, "Some Random Publisher", "Things", new TimeSpan(0, 0, 0, 0, 0) },
                    { 3, "Beatles", "MusicCD", "MusicCD", "BeatlesAbbeyRoad.jpg", "EMI", 128.00m, "EMI (2009)", "Abbey Road (Remastered)", new TimeSpan(0, 0, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Director", "Discriminator", "ImageFileName", "Price", "Title" },
                values: new object[,]
                {
                    { 8, "Movie", "Zu Quirke", "Movie", "nocturne.jpg", 190.56m, "Nocturne" },
                    { 9, "Movie", "Jan Belcl", "Movie", "deadfriends.jpg", 180.45m, "All my friends are dead" },
                    { 6, "Movie", "Someone 2", "Movie", "gladiator.jpg", 99.99m, "Gladiator" },
                    { 5, "Movie", "Someone 1", "Movie", "junglebook.jpg", 160.50m, "Jungle Book" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Author", "Category", "Discriminator", "ISBN", "ImageFileName", "Price", "Book_Publisher", "Title" },
                values: new object[] { 2, "That Author", "Book", "Book", "9999", "jungleBook.jpg", 15078.00m, "Who even cares who publishes things", "A title that makes no sense!" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Director", "Discriminator", "ImageFileName", "Price", "Title" },
                values: new object[] { 7, "Movie", "Someone 3", "Movie", "forrest-gump.jpg", 129.99m, "Forrest Gump" });

            migrationBuilder.InsertData(
                table: "Track",
                columns: new[] { "TrackId", "Composer", "Length", "MusicCDProductId", "ProductId", "Title" },
                values: new object[,]
                {
                    { 15, "Someone1", new TimeSpan(0, 0, 2, 28, 0), null, 3, "Carry That Weight" },
                    { 25, "Someone1", new TimeSpan(0, 0, 2, 28, 0), null, 4, "Here Comes The Sun" },
                    { 24, "Someone4", new TimeSpan(0, 0, 1, 14, 0), null, 4, "I Want You (She's So Heavy" },
                    { 23, "Someone1", new TimeSpan(0, 0, 2, 28, 0), null, 4, "She Came In Through The Bathroom Window" },
                    { 22, "Someone6", new TimeSpan(0, 0, 2, 28, 0), null, 4, "Polythene Pam" },
                    { 21, "Someone1", new TimeSpan(0, 0, 2, 28, 0), null, 4, "Mean Mr. Mustard" },
                    { 20, "Someone1", new TimeSpan(0, 0, 2, 28, 0), null, 4, "Sun King" },
                    { 19, "Someone2", new TimeSpan(0, 0, 1, 28, 0), null, 4, "Something" },
                    { 18, "Someone1", new TimeSpan(0, 0, 2, 28, 0), null, 4, "Come Together" },
                    { 17, "Someone1", new TimeSpan(0, 0, 2, 28, 0), null, 3, "Her Majesty" },
                    { 16, "Someone1", new TimeSpan(0, 0, 2, 28, 0), null, 3, "The End" },
                    { 14, "Someone1", new TimeSpan(0, 0, 2, 28, 0), null, 3, "Golden Slumbers" },
                    { 5, "Someone1", new TimeSpan(0, 0, 2, 15, 0), null, 3, "Octopus' Garden" },
                    { 12, "Someone6", new TimeSpan(0, 0, 2, 28, 0), null, 3, "Polythene Pam" },
                    { 11, "Someone1", new TimeSpan(0, 0, 2, 28, 0), null, 3, "Mean Mr. Mustard" },
                    { 10, "Someone1", new TimeSpan(0, 0, 2, 28, 0), null, 3, "Sun King" },
                    { 9, "Someone5", new TimeSpan(0, 0, 5, 7, 0), null, 3, "You Never Give Me Your Money" },
                    { 8, "Someone1", new TimeSpan(0, 0, 9, 11, 0), null, 3, "Because" },
                    { 7, "Someone1", new TimeSpan(0, 0, 2, 28, 0), null, 3, "Here Comes The Sun" },
                    { 6, "Someone4", new TimeSpan(0, 0, 1, 14, 0), null, 3, "I Want You (She's So Heavy" },
                    { 26, "Someone1", new TimeSpan(0, 0, 9, 11, 0), null, 4, "Because" },
                    { 4, "Someone3", new TimeSpan(0, 0, 2, 57, 0), null, 3, "Oh! Darling" },
                    { 3, "Someone1", new TimeSpan(0, 0, 2, 38, 0), null, 3, "Maxwell's Silver Hammer" },
                    { 2, "Someone2", new TimeSpan(0, 0, 1, 28, 0), null, 3, "Something" },
                    { 1, "Someone1", new TimeSpan(0, 0, 2, 28, 0), null, 3, "Come Together" }
                });

            migrationBuilder.InsertData(
                table: "Track",
                columns: new[] { "TrackId", "Composer", "Length", "MusicCDProductId", "ProductId", "Title" },
                values: new object[] { 13, "Someone1", new TimeSpan(0, 0, 2, 28, 0), null, 3, "She Came In Through The Bathroom Window" });

            migrationBuilder.InsertData(
                table: "Track",
                columns: new[] { "TrackId", "Composer", "Length", "MusicCDProductId", "ProductId", "Title" },
                values: new object[] { 27, "Someone5", new TimeSpan(0, 0, 5, 7, 0), null, 4, "You Never Give Me Your Money" });

            migrationBuilder.InsertData(
                table: "Invoice",
                columns: new[] { "InvoiceId", "CustomerId", "OrderDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, new DateTime(2021, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Phone",
                columns: new[] { "PhoneId", "CustomerId", "Number", "PhoneType" },
                values: new object[,]
                {
                    { 1, 1, 12345678, "landline" },
                    { 2, 1, 23456789, "mobile" },
                    { 3, 2, 49203491, "fax" },
                    { 4, 3, 95832849, "mobile" },
                    { 5, 4, 48219342, "landline" },
                    { 6, 5, 67129433, "landline" },
                    { 7, 6, 78959922, "mobile" },
                    { 8, 7, 11944332, "mobile" },
                    { 9, 8, 32424323, "mobile" }
                });

            migrationBuilder.InsertData(
                table: "OrderItem",
                columns: new[] { "OrderItemId", "InvoiceId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 4, 13 },
                    { 2, 1, 1, 1 },
                    { 3, 1, 8, 5 },
                    { 4, 2, 6, 8 },
                    { 5, 2, 7, 4 },
                    { 6, 2, 2, 2 },
                    { 7, 2, 5, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_CustomerId",
                table: "Invoice",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_InvoiceId",
                table: "OrderItem",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ProductId",
                table: "OrderItem",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Phone_CustomerId",
                table: "Phone",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Track_MusicCDProductId",
                table: "Track",
                column: "MusicCDProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Phone");

            migrationBuilder.DropTable(
                name: "Track");

            migrationBuilder.DropTable(
                name: "Invoice");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
