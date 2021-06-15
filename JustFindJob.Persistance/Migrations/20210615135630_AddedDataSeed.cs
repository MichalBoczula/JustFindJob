using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JustFindJob.Persistance.Migrations
{
    public partial class AddedDataSeed : Migration
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
                table: "Technologies",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "JobOfferId", "MainTechnologyImage", "MainTechnologyName", "Modified", "ModifiedBy", "StatusId" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1, null, ".Net", null, null, 0 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2, null, ".Net", null, null, 0 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3, null, ".Net", null, null, 0 },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8, null, "JavaScript", null, null, 0 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4, null, "Java", null, null, 0 },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5, null, "Java", null, null, 0 },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6, null, "Java", null, null, 0 },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7, null, "Java", null, null, 0 },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11, null, "PHP", null, null, 0 },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12, null, "Python", null, null, 0 },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9, null, "JavaScript", null, null, 0 },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10, null, "JavaScript", null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "TechnologyElement",
                columns: new[] { "Id", "Created", "CreatedBy", "ElementLevel", "ElementName", "Image", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "StatusId", "TechnologyId" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Junior", "ASP.NET", null, null, null, null, null, 0, 1 },
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Junior", "Hibernate", null, null, null, null, null, 0, 6 },
                    { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mid", "MySQL", null, null, null, null, null, 0, 7 },
                    { 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mid", "Spring", null, null, null, null, null, 0, 7 },
                    { 21, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mid", "Hibernate", null, null, null, null, null, 0, 7 },
                    { 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mid", "MySQL", null, null, null, null, null, 0, 11 },
                    { 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mid", "Symfony", null, null, null, null, null, 0, 11 },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Junior", "Spring", null, null, null, null, null, 0, 6 },
                    { 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mid", "PHPUnit", null, null, null, null, null, 0, 11 },
                    { 35, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Junior", "Django", null, null, null, null, null, 0, 12 },
                    { 36, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Junior", "Flask", null, null, null, null, null, 0, 12 },
                    { 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mid", "NoSQL", null, null, null, null, null, 0, 9 },
                    { 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mid", "Node", null, null, null, null, null, 0, 9 },
                    { 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mid", "HTML & CSS", null, null, null, null, null, 0, 9 },
                    { 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mid", "NoSQL", null, null, null, null, null, 0, 10 },
                    { 34, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Junior", "SQL", null, null, null, null, null, 0, 12 },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Junior", "MySQL", null, null, null, null, null, 0, 6 },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Senior", "Hibernate", null, null, null, null, null, 0, 5 },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Senior", "Spring", null, null, null, null, null, 0, 5 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Junior", "Angular", null, null, null, null, null, 0, 1 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Junior", "MSSQL", null, null, null, null, null, 0, 1 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mid", "ASP.NET", null, null, null, null, null, 0, 2 },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Junior", "Angular", null, null, null, null, null, 0, 2 },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mid", "MSSQL", null, null, null, null, null, 0, 2 },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mid", "ASP.NET", null, null, null, null, null, 0, 3 },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mid", "Angular", null, null, null, null, null, 0, 3 },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mid", "MSSQL", null, null, null, null, null, 0, 3 },
                    { 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Junior", "NoSQL", null, null, null, null, null, 0, 8 },
                    { 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Junior", "Node", null, null, null, null, null, 0, 8 },
                    { 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Junior", "HTML & CSS", null, null, null, null, null, 0, 8 },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Senior", "MySQL", null, null, null, null, null, 0, 4 },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Senior", "Spring", null, null, null, null, null, 0, 4 },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Senior", "Hibernate", null, null, null, null, null, 0, 4 },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Senior", "MySQL", null, null, null, null, null, 0, 5 },
                    { 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mid", "Node", null, null, null, null, null, 0, 10 },
                    { 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mid", "HTML & CSS", null, null, null, null, null, 0, 10 }
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
                table: "TechnologyElement",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TechnologyElement",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TechnologyElement",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TechnologyElement",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TechnologyElement",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TechnologyElement",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TechnologyElement",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TechnologyElement",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TechnologyElement",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TechnologyElement",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TechnologyElement",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TechnologyElement",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TechnologyElement",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TechnologyElement",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TechnologyElement",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TechnologyElement",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TechnologyElement",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TechnologyElement",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TechnologyElement",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TechnologyElement",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TechnologyElement",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TechnologyElement",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TechnologyElement",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "TechnologyElement",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "TechnologyElement",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "TechnologyElement",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "TechnologyElement",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "TechnologyElement",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "TechnologyElement",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "TechnologyElement",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "TechnologyElement",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "TechnologyElement",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "TechnologyElement",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "TechnologyElement",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "TechnologyElement",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "TechnologyElement",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: 12);

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
