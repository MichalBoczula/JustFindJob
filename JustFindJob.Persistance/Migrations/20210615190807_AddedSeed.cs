using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JustFindJob.Persistance.Migrations
{
    public partial class AddedSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Created", "CreatedBy", "Image", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "Size", "StatusId", "Type" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, null, "The Best IT", "50 - 100 employees", 0, "Software House" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, null, "Bank of Banks", "more than 250 employees", 0, "Bank" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, null, "AutoMotivo", "50 - 100 employees", 0, "Industry" },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, null, "Develop IT", "10 - 25 employees", 0, "Software House" }
                });

            migrationBuilder.InsertData(
                table: "TechnologyElements",
                columns: new[] { "Id", "Created", "CreatedBy", "Image", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "StatusId" },
                values: new object[,]
                {
                    { 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, null, "React", 0 },
                    { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, null, "Flask", 0 },
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, null, "Django", 0 },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, null, "PHPUnit", 0 },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, null, "Symfony", 0 },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, null, "NoSQL", 0 },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, null, "Node", 0 },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, null, "HTML & CSS", 0 },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, null, "Hibernate", 0 },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, null, "Spring", 0 },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, null, "MySQL", 0 },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, null, "ASP.NET", 0 },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, null, "MSSQL", 0 },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, null, "Angular", 0 },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, null, "PHP", 0 },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, null, "Python", 0 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, null, "JavaScript", 0 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, null, "Java", 0 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, null, ".Net", 0 },
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, null, "C#", 0 }
                });

            migrationBuilder.InsertData(
                table: "TechnologyLevels",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Level", "Modified", "ModifiedBy", "StatusId" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Nice to have", null, null, 0 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Begginer", null, null, 0 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Experienced", null, null, 0 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Expert", null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "CompanyDetails",
                columns: new[] { "Id", "CompanyDescription", "CompanyId", "CompanyImage1", "CompanyImage2", "CompanyImage3", "CompanyInformation1", "CompanyInformation2", "CompanyInformation3", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "StatusId" },
                values: new object[,]
                {
                    { 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque malesuada risus commodo massa mollis molestie. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Integer et finibus dolor, sed sodales ante. Praesent quis purus vitae libero porta tempus at nec nulla. Pellentesque in justo eget ligula semper maximus eget nec risus. Duis tempus neque sed est elementum mattis. Donec sit amet blandit risus. Phasellus sed magna ultricies, fermentum lorem sed, condimentum sem. Phasellus aliquam, ligula nec placerat hendrerit, urna sapien eleifend purus, fermentum sollicitudin nunc ex eu velit. Aenean laoreet, metus a facilisis luctus, eros ligula rhoncus odio, consectetur ornare nunc augue ut mi. Integer molestie pellentesque sapien at pharetra. Nunc suscipit lorem vitae ex pretium, at tempor augue iaculis. Praesent suscipit placerat mauris eget vehicula. Duis purus enim, sodales eget euismod id, commodo et tellus. Mauris sed condimentum augue, vitae tempor ex.", 1, null, null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, 0 },
                    { 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque malesuada risus commodo massa mollis molestie. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Integer et finibus dolor, sed sodales ante. Praesent quis purus vitae libero porta tempus at nec nulla. Pellentesque in justo eget ligula semper maximus eget nec risus. Duis tempus neque sed est elementum mattis. Donec sit amet blandit risus. Phasellus sed magna ultricies, fermentum lorem sed, condimentum sem. Phasellus aliquam, ligula nec placerat hendrerit, urna sapien eleifend purus, fermentum sollicitudin nunc ex eu velit. Aenean laoreet, metus a facilisis luctus, eros ligula rhoncus odio, consectetur ornare nunc augue ut mi. Integer molestie pellentesque sapien at pharetra. Nunc suscipit lorem vitae ex pretium, at tempor augue iaculis. Praesent suscipit placerat mauris eget vehicula. Duis purus enim, sodales eget euismod id, commodo et tellus. Mauris sed condimentum augue, vitae tempor ex.", 2, null, null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, 0 },
                    { 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque malesuada risus commodo massa mollis molestie. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Integer et finibus dolor, sed sodales ante. Praesent quis purus vitae libero porta tempus at nec nulla. Pellentesque in justo eget ligula semper maximus eget nec risus. Duis tempus neque sed est elementum mattis. Donec sit amet blandit risus. Phasellus sed magna ultricies, fermentum lorem sed, condimentum sem. Phasellus aliquam, ligula nec placerat hendrerit, urna sapien eleifend purus, fermentum sollicitudin nunc ex eu velit. Aenean laoreet, metus a facilisis luctus, eros ligula rhoncus odio, consectetur ornare nunc augue ut mi. Integer molestie pellentesque sapien at pharetra. Nunc suscipit lorem vitae ex pretium, at tempor augue iaculis. Praesent suscipit placerat mauris eget vehicula. Duis purus enim, sodales eget euismod id, commodo et tellus. Mauris sed condimentum augue, vitae tempor ex.", 3, null, null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, 0 },
                    { 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque malesuada risus commodo massa mollis molestie. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Integer et finibus dolor, sed sodales ante. Praesent quis purus vitae libero porta tempus at nec nulla. Pellentesque in justo eget ligula semper maximus eget nec risus. Duis tempus neque sed est elementum mattis. Donec sit amet blandit risus. Phasellus sed magna ultricies, fermentum lorem sed, condimentum sem. Phasellus aliquam, ligula nec placerat hendrerit, urna sapien eleifend purus, fermentum sollicitudin nunc ex eu velit. Aenean laoreet, metus a facilisis luctus, eros ligula rhoncus odio, consectetur ornare nunc augue ut mi. Integer molestie pellentesque sapien at pharetra. Nunc suscipit lorem vitae ex pretium, at tempor augue iaculis. Praesent suscipit placerat mauris eget vehicula. Duis purus enim, sodales eget euismod id, commodo et tellus. Mauris sed condimentum augue, vitae tempor ex.", 4, null, null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "JobOffers",
                columns: new[] { "Id", "CompanyId", "Created", "CreatedBy", "ExperienceLevel", "Inactivated", "InactivatedBy", "Localization", "LongDescription", "Modified", "ModifiedBy", "ShortDescription", "StatusId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null, null, "Wroclaw", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio. Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. Aliquam blandit tortor vitae eros porta venenatis. Nam ultrices justo purus, blandit dignissim libero elementum at. Pellentesque sed leo ac lacus faucibus sagittis sed ut tellus. Mauris eget dapibus quam. Ut est ex, egestas sit amet fermentum sit amet, lobortis nec risus. Duis vitae sodales urna. Pellentesque blandit ex in nisl laoreet, eget rutrum leo vulputate. Fusce viverra porttitor mauris, nec viverra justo dignissim varius. Nam quis commodo enim, id imperdiet lorem. In porta, augue eget laoreet tincidunt, arcu turpis laoreet enim, dapibus consequat ante nibh at sapien. Vivamus ligula velit, tincidunt et consectetur ac, tincidunt in risus. Vestibulum mattis lacinia tellus ac feugiat. Morbi eget urna volutpat ex lacinia commodo at quis nunc. Duis sapien urna, iaculis nec hendrerit at, venenatis eu massa. Proin aliquet imperdiet magna, sed ullamcorper tellus consectetur sit amet. Integer venenatis orci ac lorem commodo semper. Sed vitae risus ligula. Phasellus pulvinar laoreet lectus, sed sodales nibh feugiat non. Nunc placerat non massa et suscipit. Duis vel augue a velit vestibulum sagittis. Sed lectus urna, volutpat id nulla vel, ultrices condimentum metus. Cras cursus, enim et aliquam fermentum, neque neque mollis ante, eu lacinia sapien turpis ac mauris. Ut malesuada enim quam, non egestas dolor auctor ut. Vestibulum iaculis nec tortor faucibus fermentum.", null, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio. Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. Aliquam blandit tortor vitae eros porta venenatis.", 0 },
                    { 2, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, null, "Wroclaw", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio. Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. Aliquam blandit tortor vitae eros porta venenatis. Nam ultrices justo purus, blandit dignissim libero elementum at. Pellentesque sed leo ac lacus faucibus sagittis sed ut tellus. Mauris eget dapibus quam. Ut est ex, egestas sit amet fermentum sit amet, lobortis nec risus. Duis vitae sodales urna. Pellentesque blandit ex in nisl laoreet, eget rutrum leo vulputate. Fusce viverra porttitor mauris, nec viverra justo dignissim varius. Nam quis commodo enim, id imperdiet lorem. In porta, augue eget laoreet tincidunt, arcu turpis laoreet enim, dapibus consequat ante nibh at sapien. Vivamus ligula velit, tincidunt et consectetur ac, tincidunt in risus. Vestibulum mattis lacinia tellus ac feugiat. Morbi eget urna volutpat ex lacinia commodo at quis nunc. Duis sapien urna, iaculis nec hendrerit at, venenatis eu massa. Proin aliquet imperdiet magna, sed ullamcorper tellus consectetur sit amet. Integer venenatis orci ac lorem commodo semper. Sed vitae risus ligula. Phasellus pulvinar laoreet lectus, sed sodales nibh feugiat non. Nunc placerat non massa et suscipit. Duis vel augue a velit vestibulum sagittis. Sed lectus urna, volutpat id nulla vel, ultrices condimentum metus. Cras cursus, enim et aliquam fermentum, neque neque mollis ante, eu lacinia sapien turpis ac mauris. Ut malesuada enim quam, non egestas dolor auctor ut. Vestibulum iaculis nec tortor faucibus fermentum.", null, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio. Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. Aliquam blandit tortor vitae eros porta venenatis.", 0 },
                    { 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, null, "Poznan", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio. Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. Aliquam blandit tortor vitae eros porta venenatis. Nam ultrices justo purus, blandit dignissim libero elementum at. Pellentesque sed leo ac lacus faucibus sagittis sed ut tellus. Mauris eget dapibus quam. Ut est ex, egestas sit amet fermentum sit amet, lobortis nec risus. Duis vitae sodales urna. Pellentesque blandit ex in nisl laoreet, eget rutrum leo vulputate. Fusce viverra porttitor mauris, nec viverra justo dignissim varius. Nam quis commodo enim, id imperdiet lorem. In porta, augue eget laoreet tincidunt, arcu turpis laoreet enim, dapibus consequat ante nibh at sapien. Vivamus ligula velit, tincidunt et consectetur ac, tincidunt in risus. Vestibulum mattis lacinia tellus ac feugiat. Morbi eget urna volutpat ex lacinia commodo at quis nunc. Duis sapien urna, iaculis nec hendrerit at, venenatis eu massa. Proin aliquet imperdiet magna, sed ullamcorper tellus consectetur sit amet. Integer venenatis orci ac lorem commodo semper. Sed vitae risus ligula. Phasellus pulvinar laoreet lectus, sed sodales nibh feugiat non. Nunc placerat non massa et suscipit. Duis vel augue a velit vestibulum sagittis. Sed lectus urna, volutpat id nulla vel, ultrices condimentum metus. Cras cursus, enim et aliquam fermentum, neque neque mollis ante, eu lacinia sapien turpis ac mauris. Ut malesuada enim quam, non egestas dolor auctor ut. Vestibulum iaculis nec tortor faucibus fermentum.", null, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio. Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. Aliquam blandit tortor vitae eros porta venenatis.", 0 },
                    { 8, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null, null, "Warsaw", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio. Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. Aliquam blandit tortor vitae eros porta venenatis. Nam ultrices justo purus, blandit dignissim libero elementum at. Pellentesque sed leo ac lacus faucibus sagittis sed ut tellus. Mauris eget dapibus quam. Ut est ex, egestas sit amet fermentum sit amet, lobortis nec risus. Duis vitae sodales urna. Pellentesque blandit ex in nisl laoreet, eget rutrum leo vulputate. Fusce viverra porttitor mauris, nec viverra justo dignissim varius. Nam quis commodo enim, id imperdiet lorem. In porta, augue eget laoreet tincidunt, arcu turpis laoreet enim, dapibus consequat ante nibh at sapien. Vivamus ligula velit, tincidunt et consectetur ac, tincidunt in risus. Vestibulum mattis lacinia tellus ac feugiat. Morbi eget urna volutpat ex lacinia commodo at quis nunc. Duis sapien urna, iaculis nec hendrerit at, venenatis eu massa. Proin aliquet imperdiet magna, sed ullamcorper tellus consectetur sit amet. Integer venenatis orci ac lorem commodo semper. Sed vitae risus ligula. Phasellus pulvinar laoreet lectus, sed sodales nibh feugiat non. Nunc placerat non massa et suscipit. Duis vel augue a velit vestibulum sagittis. Sed lectus urna, volutpat id nulla vel, ultrices condimentum metus. Cras cursus, enim et aliquam fermentum, neque neque mollis ante, eu lacinia sapien turpis ac mauris. Ut malesuada enim quam, non egestas dolor auctor ut. Vestibulum iaculis nec tortor faucibus fermentum.", null, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio. Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. Aliquam blandit tortor vitae eros porta venenatis.", 0 },
                    { 4, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, null, null, "Crakow", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio. Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. Aliquam blandit tortor vitae eros porta venenatis. Nam ultrices justo purus, blandit dignissim libero elementum at. Pellentesque sed leo ac lacus faucibus sagittis sed ut tellus. Mauris eget dapibus quam. Ut est ex, egestas sit amet fermentum sit amet, lobortis nec risus. Duis vitae sodales urna. Pellentesque blandit ex in nisl laoreet, eget rutrum leo vulputate. Fusce viverra porttitor mauris, nec viverra justo dignissim varius. Nam quis commodo enim, id imperdiet lorem. In porta, augue eget laoreet tincidunt, arcu turpis laoreet enim, dapibus consequat ante nibh at sapien. Vivamus ligula velit, tincidunt et consectetur ac, tincidunt in risus. Vestibulum mattis lacinia tellus ac feugiat. Morbi eget urna volutpat ex lacinia commodo at quis nunc. Duis sapien urna, iaculis nec hendrerit at, venenatis eu massa. Proin aliquet imperdiet magna, sed ullamcorper tellus consectetur sit amet. Integer venenatis orci ac lorem commodo semper. Sed vitae risus ligula. Phasellus pulvinar laoreet lectus, sed sodales nibh feugiat non. Nunc placerat non massa et suscipit. Duis vel augue a velit vestibulum sagittis. Sed lectus urna, volutpat id nulla vel, ultrices condimentum metus. Cras cursus, enim et aliquam fermentum, neque neque mollis ante, eu lacinia sapien turpis ac mauris. Ut malesuada enim quam, non egestas dolor auctor ut. Vestibulum iaculis nec tortor faucibus fermentum.", null, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio. Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. Aliquam blandit tortor vitae eros porta venenatis.", 0 },
                    { 5, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, null, null, "Poznan", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio. Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. Aliquam blandit tortor vitae eros porta venenatis. Nam ultrices justo purus, blandit dignissim libero elementum at. Pellentesque sed leo ac lacus faucibus sagittis sed ut tellus. Mauris eget dapibus quam. Ut est ex, egestas sit amet fermentum sit amet, lobortis nec risus. Duis vitae sodales urna. Pellentesque blandit ex in nisl laoreet, eget rutrum leo vulputate. Fusce viverra porttitor mauris, nec viverra justo dignissim varius. Nam quis commodo enim, id imperdiet lorem. In porta, augue eget laoreet tincidunt, arcu turpis laoreet enim, dapibus consequat ante nibh at sapien. Vivamus ligula velit, tincidunt et consectetur ac, tincidunt in risus. Vestibulum mattis lacinia tellus ac feugiat. Morbi eget urna volutpat ex lacinia commodo at quis nunc. Duis sapien urna, iaculis nec hendrerit at, venenatis eu massa. Proin aliquet imperdiet magna, sed ullamcorper tellus consectetur sit amet. Integer venenatis orci ac lorem commodo semper. Sed vitae risus ligula. Phasellus pulvinar laoreet lectus, sed sodales nibh feugiat non. Nunc placerat non massa et suscipit. Duis vel augue a velit vestibulum sagittis. Sed lectus urna, volutpat id nulla vel, ultrices condimentum metus. Cras cursus, enim et aliquam fermentum, neque neque mollis ante, eu lacinia sapien turpis ac mauris. Ut malesuada enim quam, non egestas dolor auctor ut. Vestibulum iaculis nec tortor faucibus fermentum.", null, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio. Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. Aliquam blandit tortor vitae eros porta venenatis.", 0 },
                    { 6, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null, null, "Cracow", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio. Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. Aliquam blandit tortor vitae eros porta venenatis. Nam ultrices justo purus, blandit dignissim libero elementum at. Pellentesque sed leo ac lacus faucibus sagittis sed ut tellus. Mauris eget dapibus quam. Ut est ex, egestas sit amet fermentum sit amet, lobortis nec risus. Duis vitae sodales urna. Pellentesque blandit ex in nisl laoreet, eget rutrum leo vulputate. Fusce viverra porttitor mauris, nec viverra justo dignissim varius. Nam quis commodo enim, id imperdiet lorem. In porta, augue eget laoreet tincidunt, arcu turpis laoreet enim, dapibus consequat ante nibh at sapien. Vivamus ligula velit, tincidunt et consectetur ac, tincidunt in risus. Vestibulum mattis lacinia tellus ac feugiat. Morbi eget urna volutpat ex lacinia commodo at quis nunc. Duis sapien urna, iaculis nec hendrerit at, venenatis eu massa. Proin aliquet imperdiet magna, sed ullamcorper tellus consectetur sit amet. Integer venenatis orci ac lorem commodo semper. Sed vitae risus ligula. Phasellus pulvinar laoreet lectus, sed sodales nibh feugiat non. Nunc placerat non massa et suscipit. Duis vel augue a velit vestibulum sagittis. Sed lectus urna, volutpat id nulla vel, ultrices condimentum metus. Cras cursus, enim et aliquam fermentum, neque neque mollis ante, eu lacinia sapien turpis ac mauris. Ut malesuada enim quam, non egestas dolor auctor ut. Vestibulum iaculis nec tortor faucibus fermentum.", null, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio. Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. Aliquam blandit tortor vitae eros porta venenatis.", 0 },
                    { 7, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, null, "Warsaw", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio. Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. Aliquam blandit tortor vitae eros porta venenatis. Nam ultrices justo purus, blandit dignissim libero elementum at. Pellentesque sed leo ac lacus faucibus sagittis sed ut tellus. Mauris eget dapibus quam. Ut est ex, egestas sit amet fermentum sit amet, lobortis nec risus. Duis vitae sodales urna. Pellentesque blandit ex in nisl laoreet, eget rutrum leo vulputate. Fusce viverra porttitor mauris, nec viverra justo dignissim varius. Nam quis commodo enim, id imperdiet lorem. In porta, augue eget laoreet tincidunt, arcu turpis laoreet enim, dapibus consequat ante nibh at sapien. Vivamus ligula velit, tincidunt et consectetur ac, tincidunt in risus. Vestibulum mattis lacinia tellus ac feugiat. Morbi eget urna volutpat ex lacinia commodo at quis nunc. Duis sapien urna, iaculis nec hendrerit at, venenatis eu massa. Proin aliquet imperdiet magna, sed ullamcorper tellus consectetur sit amet. Integer venenatis orci ac lorem commodo semper. Sed vitae risus ligula. Phasellus pulvinar laoreet lectus, sed sodales nibh feugiat non. Nunc placerat non massa et suscipit. Duis vel augue a velit vestibulum sagittis. Sed lectus urna, volutpat id nulla vel, ultrices condimentum metus. Cras cursus, enim et aliquam fermentum, neque neque mollis ante, eu lacinia sapien turpis ac mauris. Ut malesuada enim quam, non egestas dolor auctor ut. Vestibulum iaculis nec tortor faucibus fermentum.", null, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio. Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. Aliquam blandit tortor vitae eros porta venenatis.", 0 },
                    { 11, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, null, "Warsaw", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio. Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. Aliquam blandit tortor vitae eros porta venenatis. Nam ultrices justo purus, blandit dignissim libero elementum at. Pellentesque sed leo ac lacus faucibus sagittis sed ut tellus. Mauris eget dapibus quam. Ut est ex, egestas sit amet fermentum sit amet, lobortis nec risus. Duis vitae sodales urna. Pellentesque blandit ex in nisl laoreet, eget rutrum leo vulputate. Fusce viverra porttitor mauris, nec viverra justo dignissim varius. Nam quis commodo enim, id imperdiet lorem. In porta, augue eget laoreet tincidunt, arcu turpis laoreet enim, dapibus consequat ante nibh at sapien. Vivamus ligula velit, tincidunt et consectetur ac, tincidunt in risus. Vestibulum mattis lacinia tellus ac feugiat. Morbi eget urna volutpat ex lacinia commodo at quis nunc. Duis sapien urna, iaculis nec hendrerit at, venenatis eu massa. Proin aliquet imperdiet magna, sed ullamcorper tellus consectetur sit amet. Integer venenatis orci ac lorem commodo semper. Sed vitae risus ligula. Phasellus pulvinar laoreet lectus, sed sodales nibh feugiat non. Nunc placerat non massa et suscipit. Duis vel augue a velit vestibulum sagittis. Sed lectus urna, volutpat id nulla vel, ultrices condimentum metus. Cras cursus, enim et aliquam fermentum, neque neque mollis ante, eu lacinia sapien turpis ac mauris. Ut malesuada enim quam, non egestas dolor auctor ut. Vestibulum iaculis nec tortor faucibus fermentum.", null, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio. Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. Aliquam blandit tortor vitae eros porta venenatis.", 0 },
                    { 12, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null, null, "Warsaw", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio. Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. Aliquam blandit tortor vitae eros porta venenatis. Nam ultrices justo purus, blandit dignissim libero elementum at. Pellentesque sed leo ac lacus faucibus sagittis sed ut tellus. Mauris eget dapibus quam. Ut est ex, egestas sit amet fermentum sit amet, lobortis nec risus. Duis vitae sodales urna. Pellentesque blandit ex in nisl laoreet, eget rutrum leo vulputate. Fusce viverra porttitor mauris, nec viverra justo dignissim varius. Nam quis commodo enim, id imperdiet lorem. In porta, augue eget laoreet tincidunt, arcu turpis laoreet enim, dapibus consequat ante nibh at sapien. Vivamus ligula velit, tincidunt et consectetur ac, tincidunt in risus. Vestibulum mattis lacinia tellus ac feugiat. Morbi eget urna volutpat ex lacinia commodo at quis nunc. Duis sapien urna, iaculis nec hendrerit at, venenatis eu massa. Proin aliquet imperdiet magna, sed ullamcorper tellus consectetur sit amet. Integer venenatis orci ac lorem commodo semper. Sed vitae risus ligula. Phasellus pulvinar laoreet lectus, sed sodales nibh feugiat non. Nunc placerat non massa et suscipit. Duis vel augue a velit vestibulum sagittis. Sed lectus urna, volutpat id nulla vel, ultrices condimentum metus. Cras cursus, enim et aliquam fermentum, neque neque mollis ante, eu lacinia sapien turpis ac mauris. Ut malesuada enim quam, non egestas dolor auctor ut. Vestibulum iaculis nec tortor faucibus fermentum.", null, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio. Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. Aliquam blandit tortor vitae eros porta venenatis.", 0 },
                    { 9, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, null, "Warsaw", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio. Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. Aliquam blandit tortor vitae eros porta venenatis. Nam ultrices justo purus, blandit dignissim libero elementum at. Pellentesque sed leo ac lacus faucibus sagittis sed ut tellus. Mauris eget dapibus quam. Ut est ex, egestas sit amet fermentum sit amet, lobortis nec risus. Duis vitae sodales urna. Pellentesque blandit ex in nisl laoreet, eget rutrum leo vulputate. Fusce viverra porttitor mauris, nec viverra justo dignissim varius. Nam quis commodo enim, id imperdiet lorem. In porta, augue eget laoreet tincidunt, arcu turpis laoreet enim, dapibus consequat ante nibh at sapien. Vivamus ligula velit, tincidunt et consectetur ac, tincidunt in risus. Vestibulum mattis lacinia tellus ac feugiat. Morbi eget urna volutpat ex lacinia commodo at quis nunc. Duis sapien urna, iaculis nec hendrerit at, venenatis eu massa. Proin aliquet imperdiet magna, sed ullamcorper tellus consectetur sit amet. Integer venenatis orci ac lorem commodo semper. Sed vitae risus ligula. Phasellus pulvinar laoreet lectus, sed sodales nibh feugiat non. Nunc placerat non massa et suscipit. Duis vel augue a velit vestibulum sagittis. Sed lectus urna, volutpat id nulla vel, ultrices condimentum metus. Cras cursus, enim et aliquam fermentum, neque neque mollis ante, eu lacinia sapien turpis ac mauris. Ut malesuada enim quam, non egestas dolor auctor ut. Vestibulum iaculis nec tortor faucibus fermentum.", null, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio. Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. Aliquam blandit tortor vitae eros porta venenatis.", 0 },
                    { 10, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, null, "Crakow", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio. Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. Aliquam blandit tortor vitae eros porta venenatis. Nam ultrices justo purus, blandit dignissim libero elementum at. Pellentesque sed leo ac lacus faucibus sagittis sed ut tellus. Mauris eget dapibus quam. Ut est ex, egestas sit amet fermentum sit amet, lobortis nec risus. Duis vitae sodales urna. Pellentesque blandit ex in nisl laoreet, eget rutrum leo vulputate. Fusce viverra porttitor mauris, nec viverra justo dignissim varius. Nam quis commodo enim, id imperdiet lorem. In porta, augue eget laoreet tincidunt, arcu turpis laoreet enim, dapibus consequat ante nibh at sapien. Vivamus ligula velit, tincidunt et consectetur ac, tincidunt in risus. Vestibulum mattis lacinia tellus ac feugiat. Morbi eget urna volutpat ex lacinia commodo at quis nunc. Duis sapien urna, iaculis nec hendrerit at, venenatis eu massa. Proin aliquet imperdiet magna, sed ullamcorper tellus consectetur sit amet. Integer venenatis orci ac lorem commodo semper. Sed vitae risus ligula. Phasellus pulvinar laoreet lectus, sed sodales nibh feugiat non. Nunc placerat non massa et suscipit. Duis vel augue a velit vestibulum sagittis. Sed lectus urna, volutpat id nulla vel, ultrices condimentum metus. Cras cursus, enim et aliquam fermentum, neque neque mollis ante, eu lacinia sapien turpis ac mauris. Ut malesuada enim quam, non egestas dolor auctor ut. Vestibulum iaculis nec tortor faucibus fermentum.", null, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio. Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. Aliquam blandit tortor vitae eros porta venenatis.", 0 }
                });

            migrationBuilder.InsertData(
                table: "TechStacks",
                columns: new[] { "JobOfferId", "TechnologyElementId", "TechnologyLevelId" },
                values: new object[,]
                {
                    { 1, 9, 2 },
                    { 2, 9, 3 },
                    { 3, 9, 3 },
                    { 8, 15, 1 },
                    { 4, 10, 4 },
                    { 5, 10, 4 },
                    { 6, 10, 1 },
                    { 7, 4, 3 },
                    { 11, 5, 3 },
                    { 12, 17, 2 },
                    { 9, 15, 3 },
                    { 10, 15, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompanyDetails",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CompanyDetails",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CompanyDetails",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CompanyDetails",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 4, 11 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 4, 12 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 5, 10 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 5, 11 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 5, 12 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 6, 10 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 6, 11 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 6, 12 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 6, 13 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 7, 13 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 7, 20 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 8, 13 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 8, 14 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 8, 15 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 8, 20 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 9, 13 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 9, 14 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 9, 15 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 9, 20 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 10, 13 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 10, 14 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 10, 15 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 11, 5 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 11, 10 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 11, 18 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 11, 19 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 12, 6 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 12, 10 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 12, 16 });

            migrationBuilder.DeleteData(
                table: "TechStacks",
                keyColumns: new[] { "JobOfferId", "TechnologyElementId" },
                keyValues: new object[] { 12, 17 });

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TechnologyElements",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TechnologyElements",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TechnologyElements",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TechnologyElements",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TechnologyElements",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TechnologyElements",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TechnologyElements",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TechnologyElements",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TechnologyElements",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TechnologyElements",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TechnologyElements",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TechnologyElements",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TechnologyElements",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TechnologyElements",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TechnologyElements",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TechnologyElements",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TechnologyElements",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TechnologyElements",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TechnologyElements",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TechnologyElements",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TechnologyLevels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TechnologyLevels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TechnologyLevels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TechnologyLevels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
