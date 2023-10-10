using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DoAnCS_Demo1.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "email", "name", "password", "username" },
                values: new object[,]
                {
                    { 1, "cfillery0@hubpages.com", "Correy Fillery", "rbenrnju)K1R7r'", "cfillery0" },
                    { 2, "cninnis1@sogou.com", "Casandra Ninnis", "avfaxpxu?9!D4'", "cninnis1" },
                    { 3, "wwhitely2@businesswire.com", "Wiley Whitely", "jclrsecgA", "wwhitely2" },
                    { 4, "cberwick3@constantcontact.com", "Candice Berwick", "ihwzuavt", "cberwick3" },
                    { 5, "bmarden4@linkedin.com", "Beret Marden", "uurxsltd1", "bmarden4" },
                    { 6, "ajudge5@privacy.gov.au", "Alvis Judge", "lcehggcko", "ajudge5" },
                    { 7, "laneley6@wikispaces.com", "Lemuel Aneley", "mgkebjqu", "laneley6" },
                    { 8, "ikilford7@nationalgeographic.com", "Ines Kilford", "dkneunzk*5vYc", "ikilford7" },
                    { 9, "sschollick8@hud.gov", "Shannan Schollick", "cnwqiswsPjl6/8u/", "sschollick8" },
                    { 10, "rweson9@list-manage.com", "Rozanne Weson", "wmwjhubsb", "rweson9" },
                    { 11, "cbolzena@techcrunch.com", "Ches Bolzen", "sdnsdtpsZ8&|P@Zu", "cbolzena" },
                    { 12, "fohickeeb@quantcast.com", "Filippo O'Hickee", "rfbygomr6AF9j", "fohickeeb" },
                    { 13, "tdomeganc@instagram.com", "Teresa Domegan", "hzityiykZ", "tdomeganc" },
                    { 14, "salmonmacalpine@gmail.com", "Salmon MacAlpine", "kbvulodh", "smacalpined" },
                    { 15, "vgiereke@msu.edu", "Valentin Gierek", "ulwvqthf.", "vgiereke" },
                    { 16, "hduthief@goo.gl", "Horten Duthie", "wtlpzxqe`=1ek*QU", "hduthief" },
                    { 17, "hhengoedg@twitter.com", "Holt Hengoed", "owraixrwl*_~Pu", "hhengoedg" },
                    { 18, "rsacaseh@ezinearticles.com", "Renae Sacase", "nyimvjgeH5&_m", "rsacaseh" },
                    { 19, "egreystokei@pagesperso-orange.fr", "Ethelda Greystoke", "etysnblfN", "egreystokei" },
                    { 20, "hborgbartoloj@netlog.com", "Hazel Borg-Bartolo", "twfrouhb&.lZ/LWH", "hborgbartoloj" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");
        }
    }
}
