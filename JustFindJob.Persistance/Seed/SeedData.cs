using JustFindJob.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFindJob.Persistance.Seed
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JobOffer>().HasData(
                new JobOffer()
                {
                    Id = 1,
                    CompanyId = 1,
                    Localization = "Wroclaw",
                    ExperienceLevel = ExperienceLevels.Junior,
                    ProgrammingLanguageId = 1,
                    ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio." +
                    " Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. " +
                    "Aliquam blandit tortor vitae eros porta venenatis.",
                    LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio." +
                    " Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. " +
                    "Aliquam blandit tortor vitae eros porta venenatis. Nam ultrices justo purus, blandit dignissim libero elementum at." +
                    " Pellentesque sed leo ac lacus faucibus sagittis sed ut tellus. Mauris eget dapibus quam. Ut est ex, egestas sit" +
                    " amet fermentum sit amet, lobortis nec risus. Duis vitae sodales urna. Pellentesque blandit ex in nisl laoreet," +
                    " eget rutrum leo vulputate. Fusce viverra porttitor mauris, nec viverra justo dignissim varius. Nam quis commodo " +
                    "enim, id imperdiet lorem. In porta, augue eget laoreet tincidunt, arcu turpis laoreet enim, dapibus consequat ante" +
                    " nibh at sapien. Vivamus ligula velit, tincidunt et consectetur ac, tincidunt in risus. Vestibulum mattis lacinia " +
                    "tellus ac feugiat. Morbi eget urna volutpat ex lacinia commodo at quis nunc. Duis sapien urna," +
                    " iaculis nec hendrerit at, venenatis eu massa. Proin aliquet imperdiet magna, sed ullamcorper tellus " +
                    "consectetur sit amet. Integer venenatis orci ac lorem commodo semper. Sed vitae risus ligula. Phasellus " +
                    "pulvinar laoreet lectus, sed sodales nibh feugiat non. Nunc placerat non massa et suscipit. Duis vel augue a " +
                    "velit vestibulum sagittis. Sed lectus urna, volutpat id nulla vel, ultrices condimentum metus. Cras cursus, enim " +
                    "et aliquam fermentum, neque neque mollis ante, eu lacinia sapien turpis ac mauris. Ut malesuada enim quam, " +
                    "non egestas dolor auctor ut. Vestibulum iaculis nec tortor faucibus fermentum."
                },
                new JobOffer()
                {
                    Id = 2,
                    CompanyId = 1,
                    Localization = "Wroclaw",
                    ExperienceLevel = ExperienceLevels.Mid,
                    ProgrammingLanguageId = 1,
                    ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio." +
                    " Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. " +
                    "Aliquam blandit tortor vitae eros porta venenatis.",
                    LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio." +
                    " Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. " +
                    "Aliquam blandit tortor vitae eros porta venenatis. Nam ultrices justo purus, blandit dignissim libero elementum at." +
                    " Pellentesque sed leo ac lacus faucibus sagittis sed ut tellus. Mauris eget dapibus quam. Ut est ex, egestas sit" +
                    " amet fermentum sit amet, lobortis nec risus. Duis vitae sodales urna. Pellentesque blandit ex in nisl laoreet," +
                    " eget rutrum leo vulputate. Fusce viverra porttitor mauris, nec viverra justo dignissim varius. Nam quis commodo " +
                    "enim, id imperdiet lorem. In porta, augue eget laoreet tincidunt, arcu turpis laoreet enim, dapibus consequat ante" +
                    " nibh at sapien. Vivamus ligula velit, tincidunt et consectetur ac, tincidunt in risus. Vestibulum mattis lacinia " +
                    "tellus ac feugiat. Morbi eget urna volutpat ex lacinia commodo at quis nunc. Duis sapien urna," +
                    " iaculis nec hendrerit at, venenatis eu massa. Proin aliquet imperdiet magna, sed ullamcorper tellus " +
                    "consectetur sit amet. Integer venenatis orci ac lorem commodo semper. Sed vitae risus ligula. Phasellus " +
                    "pulvinar laoreet lectus, sed sodales nibh feugiat non. Nunc placerat non massa et suscipit. Duis vel augue a " +
                    "velit vestibulum sagittis. Sed lectus urna, volutpat id nulla vel, ultrices condimentum metus. Cras cursus, enim " +
                    "et aliquam fermentum, neque neque mollis ante, eu lacinia sapien turpis ac mauris. Ut malesuada enim quam, " +
                    "non egestas dolor auctor ut. Vestibulum iaculis nec tortor faucibus fermentum."
                },
                new JobOffer()
                {
                    Id = 3,
                    CompanyId = 1,
                    Localization = "Poznan",
                    ExperienceLevel = ExperienceLevels.Mid,
                    ProgrammingLanguageId = 1,
                    ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio." +
                    " Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. " +
                    "Aliquam blandit tortor vitae eros porta venenatis.",
                    LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio." +
                    " Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. " +
                    "Aliquam blandit tortor vitae eros porta venenatis. Nam ultrices justo purus, blandit dignissim libero elementum at." +
                    " Pellentesque sed leo ac lacus faucibus sagittis sed ut tellus. Mauris eget dapibus quam. Ut est ex, egestas sit" +
                    " amet fermentum sit amet, lobortis nec risus. Duis vitae sodales urna. Pellentesque blandit ex in nisl laoreet," +
                    " eget rutrum leo vulputate. Fusce viverra porttitor mauris, nec viverra justo dignissim varius. Nam quis commodo " +
                    "enim, id imperdiet lorem. In porta, augue eget laoreet tincidunt, arcu turpis laoreet enim, dapibus consequat ante" +
                    " nibh at sapien. Vivamus ligula velit, tincidunt et consectetur ac, tincidunt in risus. Vestibulum mattis lacinia " +
                    "tellus ac feugiat. Morbi eget urna volutpat ex lacinia commodo at quis nunc. Duis sapien urna," +
                    " iaculis nec hendrerit at, venenatis eu massa. Proin aliquet imperdiet magna, sed ullamcorper tellus " +
                    "consectetur sit amet. Integer venenatis orci ac lorem commodo semper. Sed vitae risus ligula. Phasellus " +
                    "pulvinar laoreet lectus, sed sodales nibh feugiat non. Nunc placerat non massa et suscipit. Duis vel augue a " +
                    "velit vestibulum sagittis. Sed lectus urna, volutpat id nulla vel, ultrices condimentum metus. Cras cursus, enim " +
                    "et aliquam fermentum, neque neque mollis ante, eu lacinia sapien turpis ac mauris. Ut malesuada enim quam, " +
                    "non egestas dolor auctor ut. Vestibulum iaculis nec tortor faucibus fermentum."
                },
                new JobOffer()
                {
                    Id = 4,
                    CompanyId = 2,
                    Localization = "Crakow",
                    ExperienceLevel = ExperienceLevels.Senior,
                    ProgrammingLanguageId = 2,
                    ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio." +
                    " Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. " +
                    "Aliquam blandit tortor vitae eros porta venenatis.",
                    LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio." +
                    " Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. " +
                    "Aliquam blandit tortor vitae eros porta venenatis. Nam ultrices justo purus, blandit dignissim libero elementum at." +
                    " Pellentesque sed leo ac lacus faucibus sagittis sed ut tellus. Mauris eget dapibus quam. Ut est ex, egestas sit" +
                    " amet fermentum sit amet, lobortis nec risus. Duis vitae sodales urna. Pellentesque blandit ex in nisl laoreet," +
                    " eget rutrum leo vulputate. Fusce viverra porttitor mauris, nec viverra justo dignissim varius. Nam quis commodo " +
                    "enim, id imperdiet lorem. In porta, augue eget laoreet tincidunt, arcu turpis laoreet enim, dapibus consequat ante" +
                    " nibh at sapien. Vivamus ligula velit, tincidunt et consectetur ac, tincidunt in risus. Vestibulum mattis lacinia " +
                    "tellus ac feugiat. Morbi eget urna volutpat ex lacinia commodo at quis nunc. Duis sapien urna," +
                    " iaculis nec hendrerit at, venenatis eu massa. Proin aliquet imperdiet magna, sed ullamcorper tellus " +
                    "consectetur sit amet. Integer venenatis orci ac lorem commodo semper. Sed vitae risus ligula. Phasellus " +
                    "pulvinar laoreet lectus, sed sodales nibh feugiat non. Nunc placerat non massa et suscipit. Duis vel augue a " +
                    "velit vestibulum sagittis. Sed lectus urna, volutpat id nulla vel, ultrices condimentum metus. Cras cursus, enim " +
                    "et aliquam fermentum, neque neque mollis ante, eu lacinia sapien turpis ac mauris. Ut malesuada enim quam, " +
                    "non egestas dolor auctor ut. Vestibulum iaculis nec tortor faucibus fermentum."
                },
                new JobOffer()
                {
                    Id = 5,
                    CompanyId = 2,
                    Localization = "Poznan",
                    ExperienceLevel = ExperienceLevels.Senior,
                    ProgrammingLanguageId = 2,
                    ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio." +
                    " Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. " +
                    "Aliquam blandit tortor vitae eros porta venenatis.",
                    LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio." +
                    " Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. " +
                    "Aliquam blandit tortor vitae eros porta venenatis. Nam ultrices justo purus, blandit dignissim libero elementum at." +
                    " Pellentesque sed leo ac lacus faucibus sagittis sed ut tellus. Mauris eget dapibus quam. Ut est ex, egestas sit" +
                    " amet fermentum sit amet, lobortis nec risus. Duis vitae sodales urna. Pellentesque blandit ex in nisl laoreet," +
                    " eget rutrum leo vulputate. Fusce viverra porttitor mauris, nec viverra justo dignissim varius. Nam quis commodo " +
                    "enim, id imperdiet lorem. In porta, augue eget laoreet tincidunt, arcu turpis laoreet enim, dapibus consequat ante" +
                    " nibh at sapien. Vivamus ligula velit, tincidunt et consectetur ac, tincidunt in risus. Vestibulum mattis lacinia " +
                    "tellus ac feugiat. Morbi eget urna volutpat ex lacinia commodo at quis nunc. Duis sapien urna," +
                    " iaculis nec hendrerit at, venenatis eu massa. Proin aliquet imperdiet magna, sed ullamcorper tellus " +
                    "consectetur sit amet. Integer venenatis orci ac lorem commodo semper. Sed vitae risus ligula. Phasellus " +
                    "pulvinar laoreet lectus, sed sodales nibh feugiat non. Nunc placerat non massa et suscipit. Duis vel augue a " +
                    "velit vestibulum sagittis. Sed lectus urna, volutpat id nulla vel, ultrices condimentum metus. Cras cursus, enim " +
                    "et aliquam fermentum, neque neque mollis ante, eu lacinia sapien turpis ac mauris. Ut malesuada enim quam, " +
                    "non egestas dolor auctor ut. Vestibulum iaculis nec tortor faucibus fermentum."
                },
                new JobOffer()
                {
                    Id = 6,
                    CompanyId = 2,
                    Localization = "Cracow",
                    ExperienceLevel = ExperienceLevels.Junior,
                    ProgrammingLanguageId = 2,
                    ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio." +
                    " Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. " +
                    "Aliquam blandit tortor vitae eros porta venenatis.",
                    LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio." +
                    " Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. " +
                    "Aliquam blandit tortor vitae eros porta venenatis. Nam ultrices justo purus, blandit dignissim libero elementum at." +
                    " Pellentesque sed leo ac lacus faucibus sagittis sed ut tellus. Mauris eget dapibus quam. Ut est ex, egestas sit" +
                    " amet fermentum sit amet, lobortis nec risus. Duis vitae sodales urna. Pellentesque blandit ex in nisl laoreet," +
                    " eget rutrum leo vulputate. Fusce viverra porttitor mauris, nec viverra justo dignissim varius. Nam quis commodo " +
                    "enim, id imperdiet lorem. In porta, augue eget laoreet tincidunt, arcu turpis laoreet enim, dapibus consequat ante" +
                    " nibh at sapien. Vivamus ligula velit, tincidunt et consectetur ac, tincidunt in risus. Vestibulum mattis lacinia " +
                    "tellus ac feugiat. Morbi eget urna volutpat ex lacinia commodo at quis nunc. Duis sapien urna," +
                    " iaculis nec hendrerit at, venenatis eu massa. Proin aliquet imperdiet magna, sed ullamcorper tellus " +
                    "consectetur sit amet. Integer venenatis orci ac lorem commodo semper. Sed vitae risus ligula. Phasellus " +
                    "pulvinar laoreet lectus, sed sodales nibh feugiat non. Nunc placerat non massa et suscipit. Duis vel augue a " +
                    "velit vestibulum sagittis. Sed lectus urna, volutpat id nulla vel, ultrices condimentum metus. Cras cursus, enim " +
                    "et aliquam fermentum, neque neque mollis ante, eu lacinia sapien turpis ac mauris. Ut malesuada enim quam, " +
                    "non egestas dolor auctor ut. Vestibulum iaculis nec tortor faucibus fermentum."
                },
                new JobOffer()
                {
                    Id = 7,
                    CompanyId = 2,
                    Localization = "Warsaw",
                    ExperienceLevel = ExperienceLevels.Mid,
                    ProgrammingLanguageId = 3,
                    ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio." +
                    " Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. " +
                    "Aliquam blandit tortor vitae eros porta venenatis.",
                    LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio." +
                    " Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. " +
                    "Aliquam blandit tortor vitae eros porta venenatis. Nam ultrices justo purus, blandit dignissim libero elementum at." +
                    " Pellentesque sed leo ac lacus faucibus sagittis sed ut tellus. Mauris eget dapibus quam. Ut est ex, egestas sit" +
                    " amet fermentum sit amet, lobortis nec risus. Duis vitae sodales urna. Pellentesque blandit ex in nisl laoreet," +
                    " eget rutrum leo vulputate. Fusce viverra porttitor mauris, nec viverra justo dignissim varius. Nam quis commodo " +
                    "enim, id imperdiet lorem. In porta, augue eget laoreet tincidunt, arcu turpis laoreet enim, dapibus consequat ante" +
                    " nibh at sapien. Vivamus ligula velit, tincidunt et consectetur ac, tincidunt in risus. Vestibulum mattis lacinia " +
                    "tellus ac feugiat. Morbi eget urna volutpat ex lacinia commodo at quis nunc. Duis sapien urna," +
                    " iaculis nec hendrerit at, venenatis eu massa. Proin aliquet imperdiet magna, sed ullamcorper tellus " +
                    "consectetur sit amet. Integer venenatis orci ac lorem commodo semper. Sed vitae risus ligula. Phasellus " +
                    "pulvinar laoreet lectus, sed sodales nibh feugiat non. Nunc placerat non massa et suscipit. Duis vel augue a " +
                    "velit vestibulum sagittis. Sed lectus urna, volutpat id nulla vel, ultrices condimentum metus. Cras cursus, enim " +
                    "et aliquam fermentum, neque neque mollis ante, eu lacinia sapien turpis ac mauris. Ut malesuada enim quam, " +
                    "non egestas dolor auctor ut. Vestibulum iaculis nec tortor faucibus fermentum."
                },
                new JobOffer()
                {
                    Id = 8,
                    CompanyId = 1,
                    Localization = "Warsaw",
                    ExperienceLevel = ExperienceLevels.Junior,
                    ProgrammingLanguageId = 3,
                    ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio." +
                    " Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. " +
                    "Aliquam blandit tortor vitae eros porta venenatis.",
                    LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio." +
                    " Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. " +
                    "Aliquam blandit tortor vitae eros porta venenatis. Nam ultrices justo purus, blandit dignissim libero elementum at." +
                    " Pellentesque sed leo ac lacus faucibus sagittis sed ut tellus. Mauris eget dapibus quam. Ut est ex, egestas sit" +
                    " amet fermentum sit amet, lobortis nec risus. Duis vitae sodales urna. Pellentesque blandit ex in nisl laoreet," +
                    " eget rutrum leo vulputate. Fusce viverra porttitor mauris, nec viverra justo dignissim varius. Nam quis commodo " +
                    "enim, id imperdiet lorem. In porta, augue eget laoreet tincidunt, arcu turpis laoreet enim, dapibus consequat ante" +
                    " nibh at sapien. Vivamus ligula velit, tincidunt et consectetur ac, tincidunt in risus. Vestibulum mattis lacinia " +
                    "tellus ac feugiat. Morbi eget urna volutpat ex lacinia commodo at quis nunc. Duis sapien urna," +
                    " iaculis nec hendrerit at, venenatis eu massa. Proin aliquet imperdiet magna, sed ullamcorper tellus " +
                    "consectetur sit amet. Integer venenatis orci ac lorem commodo semper. Sed vitae risus ligula. Phasellus " +
                    "pulvinar laoreet lectus, sed sodales nibh feugiat non. Nunc placerat non massa et suscipit. Duis vel augue a " +
                    "velit vestibulum sagittis. Sed lectus urna, volutpat id nulla vel, ultrices condimentum metus. Cras cursus, enim " +
                    "et aliquam fermentum, neque neque mollis ante, eu lacinia sapien turpis ac mauris. Ut malesuada enim quam, " +
                    "non egestas dolor auctor ut. Vestibulum iaculis nec tortor faucibus fermentum."
                },
                new JobOffer()
                {
                    Id = 9,
                    CompanyId = 4,
                    Localization = "Warsaw",
                    ExperienceLevel = ExperienceLevels.Mid,
                    ProgrammingLanguageId = 3,
                    ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio." +
                    " Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. " +
                    "Aliquam blandit tortor vitae eros porta venenatis.",
                    LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio." +
                    " Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. " +
                    "Aliquam blandit tortor vitae eros porta venenatis. Nam ultrices justo purus, blandit dignissim libero elementum at." +
                    " Pellentesque sed leo ac lacus faucibus sagittis sed ut tellus. Mauris eget dapibus quam. Ut est ex, egestas sit" +
                    " amet fermentum sit amet, lobortis nec risus. Duis vitae sodales urna. Pellentesque blandit ex in nisl laoreet," +
                    " eget rutrum leo vulputate. Fusce viverra porttitor mauris, nec viverra justo dignissim varius. Nam quis commodo " +
                    "enim, id imperdiet lorem. In porta, augue eget laoreet tincidunt, arcu turpis laoreet enim, dapibus consequat ante" +
                    " nibh at sapien. Vivamus ligula velit, tincidunt et consectetur ac, tincidunt in risus. Vestibulum mattis lacinia " +
                    "tellus ac feugiat. Morbi eget urna volutpat ex lacinia commodo at quis nunc. Duis sapien urna," +
                    " iaculis nec hendrerit at, venenatis eu massa. Proin aliquet imperdiet magna, sed ullamcorper tellus " +
                    "consectetur sit amet. Integer venenatis orci ac lorem commodo semper. Sed vitae risus ligula. Phasellus " +
                    "pulvinar laoreet lectus, sed sodales nibh feugiat non. Nunc placerat non massa et suscipit. Duis vel augue a " +
                    "velit vestibulum sagittis. Sed lectus urna, volutpat id nulla vel, ultrices condimentum metus. Cras cursus, enim " +
                    "et aliquam fermentum, neque neque mollis ante, eu lacinia sapien turpis ac mauris. Ut malesuada enim quam, " +
                    "non egestas dolor auctor ut. Vestibulum iaculis nec tortor faucibus fermentum."
                },
                new JobOffer()
                {
                    Id = 10,
                    CompanyId = 4,
                    Localization = "Crakow",
                    ExperienceLevel = ExperienceLevels.Mid,
                    ProgrammingLanguageId = 3,
                    ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio." +
                    " Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. " +
                    "Aliquam blandit tortor vitae eros porta venenatis.",
                    LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio." +
                    " Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. " +
                    "Aliquam blandit tortor vitae eros porta venenatis. Nam ultrices justo purus, blandit dignissim libero elementum at." +
                    " Pellentesque sed leo ac lacus faucibus sagittis sed ut tellus. Mauris eget dapibus quam. Ut est ex, egestas sit" +
                    " amet fermentum sit amet, lobortis nec risus. Duis vitae sodales urna. Pellentesque blandit ex in nisl laoreet," +
                    " eget rutrum leo vulputate. Fusce viverra porttitor mauris, nec viverra justo dignissim varius. Nam quis commodo " +
                    "enim, id imperdiet lorem. In porta, augue eget laoreet tincidunt, arcu turpis laoreet enim, dapibus consequat ante" +
                    " nibh at sapien. Vivamus ligula velit, tincidunt et consectetur ac, tincidunt in risus. Vestibulum mattis lacinia " +
                    "tellus ac feugiat. Morbi eget urna volutpat ex lacinia commodo at quis nunc. Duis sapien urna," +
                    " iaculis nec hendrerit at, venenatis eu massa. Proin aliquet imperdiet magna, sed ullamcorper tellus " +
                    "consectetur sit amet. Integer venenatis orci ac lorem commodo semper. Sed vitae risus ligula. Phasellus " +
                    "pulvinar laoreet lectus, sed sodales nibh feugiat non. Nunc placerat non massa et suscipit. Duis vel augue a " +
                    "velit vestibulum sagittis. Sed lectus urna, volutpat id nulla vel, ultrices condimentum metus. Cras cursus, enim " +
                    "et aliquam fermentum, neque neque mollis ante, eu lacinia sapien turpis ac mauris. Ut malesuada enim quam, " +
                    "non egestas dolor auctor ut. Vestibulum iaculis nec tortor faucibus fermentum."
                },
                new JobOffer()
                {
                    Id = 11,
                    CompanyId = 3,
                    Localization = "Warsaw",
                    ExperienceLevel = ExperienceLevels.Mid,
                    ProgrammingLanguageId = 5,
                    ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio." +
                    " Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. " +
                    "Aliquam blandit tortor vitae eros porta venenatis.",
                    LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio." +
                    " Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. " +
                    "Aliquam blandit tortor vitae eros porta venenatis. Nam ultrices justo purus, blandit dignissim libero elementum at." +
                    " Pellentesque sed leo ac lacus faucibus sagittis sed ut tellus. Mauris eget dapibus quam. Ut est ex, egestas sit" +
                    " amet fermentum sit amet, lobortis nec risus. Duis vitae sodales urna. Pellentesque blandit ex in nisl laoreet," +
                    " eget rutrum leo vulputate. Fusce viverra porttitor mauris, nec viverra justo dignissim varius. Nam quis commodo " +
                    "enim, id imperdiet lorem. In porta, augue eget laoreet tincidunt, arcu turpis laoreet enim, dapibus consequat ante" +
                    " nibh at sapien. Vivamus ligula velit, tincidunt et consectetur ac, tincidunt in risus. Vestibulum mattis lacinia " +
                    "tellus ac feugiat. Morbi eget urna volutpat ex lacinia commodo at quis nunc. Duis sapien urna," +
                    " iaculis nec hendrerit at, venenatis eu massa. Proin aliquet imperdiet magna, sed ullamcorper tellus " +
                    "consectetur sit amet. Integer venenatis orci ac lorem commodo semper. Sed vitae risus ligula. Phasellus " +
                    "pulvinar laoreet lectus, sed sodales nibh feugiat non. Nunc placerat non massa et suscipit. Duis vel augue a " +
                    "velit vestibulum sagittis. Sed lectus urna, volutpat id nulla vel, ultrices condimentum metus. Cras cursus, enim " +
                    "et aliquam fermentum, neque neque mollis ante, eu lacinia sapien turpis ac mauris. Ut malesuada enim quam, " +
                    "non egestas dolor auctor ut. Vestibulum iaculis nec tortor faucibus fermentum."
                },
                new JobOffer()
                {
                    Id = 12,
                    CompanyId = 3,
                    Localization = "Warsaw",
                    ExperienceLevel = ExperienceLevels.Junior,
                    ProgrammingLanguageId = 4,
                    ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio." +
                    " Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. " +
                    "Aliquam blandit tortor vitae eros porta venenatis.",
                    LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc eget rhoncus odio." +
                    " Donec blandit at felis eu finibus. Aenean rhoncus est massa, ut dapibus dolor viverra ut. " +
                    "Aliquam blandit tortor vitae eros porta venenatis. Nam ultrices justo purus, blandit dignissim libero elementum at." +
                    " Pellentesque sed leo ac lacus faucibus sagittis sed ut tellus. Mauris eget dapibus quam. Ut est ex, egestas sit" +
                    " amet fermentum sit amet, lobortis nec risus. Duis vitae sodales urna. Pellentesque blandit ex in nisl laoreet," +
                    " eget rutrum leo vulputate. Fusce viverra porttitor mauris, nec viverra justo dignissim varius. Nam quis commodo " +
                    "enim, id imperdiet lorem. In porta, augue eget laoreet tincidunt, arcu turpis laoreet enim, dapibus consequat ante" +
                    " nibh at sapien. Vivamus ligula velit, tincidunt et consectetur ac, tincidunt in risus. Vestibulum mattis lacinia " +
                    "tellus ac feugiat. Morbi eget urna volutpat ex lacinia commodo at quis nunc. Duis sapien urna," +
                    " iaculis nec hendrerit at, venenatis eu massa. Proin aliquet imperdiet magna, sed ullamcorper tellus " +
                    "consectetur sit amet. Integer venenatis orci ac lorem commodo semper. Sed vitae risus ligula. Phasellus " +
                    "pulvinar laoreet lectus, sed sodales nibh feugiat non. Nunc placerat non massa et suscipit. Duis vel augue a " +
                    "velit vestibulum sagittis. Sed lectus urna, volutpat id nulla vel, ultrices condimentum metus. Cras cursus, enim " +
                    "et aliquam fermentum, neque neque mollis ante, eu lacinia sapien turpis ac mauris. Ut malesuada enim quam, " +
                    "non egestas dolor auctor ut. Vestibulum iaculis nec tortor faucibus fermentum."
                }
            );

            modelBuilder.Entity<Company>().HasData(
               new Company()
               {
                   Id = 1,
                   Name = "The Best IT",
                   Size = "50 - 100 employees",
                   Type = "Software House"
               },
               new Company()
               {
                   Id = 2,
                   Name = "Bank of Banks",
                   Size = "more than 250 employees",
                   Type = "Bank"
               },
               new Company()
               {
                   Id = 3,
                   Name = "AutoMotivo",
                   Size = "50 - 100 employees",
                   Type = "Industry"
               },
               new Company()
               {
                   Id = 4,
                   Name = "Develop IT",
                   Size = "10 - 25 employees",
                   Type = "Software House"
               }
           );

            modelBuilder.Entity<CompanyDetails>().HasData(
               new CompanyDetails()
               {
                   Id = 1,
                   CompanyId = 1,
                   CompanyDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                   " Pellentesque malesuada risus commodo massa mollis molestie. Class aptent taciti sociosqu ad litora torquent per" +
                   " conubia nostra, per inceptos himenaeos. Integer et finibus dolor, sed sodales ante. Praesent quis purus vitae" +
                   " libero porta tempus at nec nulla. Pellentesque in justo eget ligula semper maximus eget nec risus. Duis tempus" +
                   " neque sed est elementum mattis. Donec sit amet blandit risus. Phasellus sed magna ultricies, fermentum lorem sed," +
                   " condimentum sem. Phasellus aliquam, ligula nec placerat hendrerit, urna sapien eleifend purus," +
                   " fermentum sollicitudin nunc ex eu velit. Aenean laoreet, metus a facilisis luctus, eros ligula rhoncus odio," +
                   " consectetur ornare nunc augue ut mi. Integer molestie pellentesque sapien at pharetra." +
                   " Nunc suscipit lorem vitae ex pretium, at tempor augue iaculis. Praesent suscipit placerat mauris eget vehicula. " +
                   "Duis purus enim, sodales eget euismod id, commodo et tellus. Mauris sed condimentum augue, vitae tempor ex."
               },
               new CompanyDetails()
               {
                   Id = 2,
                   CompanyId = 2,
                   CompanyDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                   " Pellentesque malesuada risus commodo massa mollis molestie. Class aptent taciti sociosqu ad litora torquent per " +
                   "conubia nostra, per inceptos himenaeos. Integer et finibus dolor, sed sodales ante. Praesent quis purus vitae " +
                   "libero porta tempus at nec nulla. Pellentesque in justo eget ligula semper maximus eget nec risus." +
                   " Duis tempus neque sed est elementum mattis. Donec sit amet blandit risus. Phasellus sed magna ultricies, " +
                   "fermentum lorem sed, condimentum sem. Phasellus aliquam, ligula nec placerat hendrerit, urna sapien eleifend purus, " +
                   "fermentum sollicitudin nunc ex eu velit. Aenean laoreet, metus a facilisis luctus, eros ligula rhoncus odio," +
                   " consectetur ornare nunc augue ut mi. Integer molestie pellentesque sapien at pharetra. Nunc suscipit lorem vitae" +
                   " ex pretium, at tempor augue iaculis. Praesent suscipit placerat mauris eget vehicula. Duis purus enim, sodales " +
                   "eget euismod id, commodo et tellus. Mauris sed condimentum augue, vitae tempor ex."
               },
               new CompanyDetails()
               {
                   Id = 3,
                   CompanyId = 3,
                   CompanyDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                   "Pellentesque malesuada risus commodo massa mollis molestie. Class aptent taciti sociosqu ad litora torquent per " +
                   "conubia nostra, per inceptos himenaeos. Integer et finibus dolor, sed sodales ante. Praesent quis purus vitae libero " +
                   "porta tempus at nec nulla. Pellentesque in justo eget ligula semper maximus eget nec risus. Duis tempus neque sed est" +
                   " elementum mattis. Donec sit amet blandit risus. Phasellus sed magna ultricies, fermentum lorem sed, condimentum sem. " +
                   "Phasellus aliquam, ligula nec placerat hendrerit, urna sapien eleifend purus, fermentum sollicitudin nunc ex eu velit." +
                   " Aenean laoreet, metus a facilisis luctus, eros ligula rhoncus odio, consectetur ornare nunc augue ut mi." +
                   " Integer molestie pellentesque sapien at pharetra. Nunc suscipit lorem vitae ex pretium, at tempor augue iaculis." +
                   " Praesent suscipit placerat mauris eget vehicula. Duis purus enim, sodales eget euismod id, commodo et tellus." +
                   " Mauris sed condimentum augue, vitae tempor ex."
               },
               new CompanyDetails()
               {
                   Id = 4,
                   CompanyId = 4,
                   CompanyDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                   " Pellentesque malesuada risus commodo massa mollis molestie. Class aptent taciti sociosqu ad litora torquent per " +
                   "conubia nostra, per inceptos himenaeos. Integer et finibus dolor, sed sodales ante. Praesent quis purus vitae libero " +
                   "porta tempus at nec nulla. Pellentesque in justo eget ligula semper maximus eget nec risus. Duis tempus neque sed est" +
                   " elementum mattis. Donec sit amet blandit risus. Phasellus sed magna ultricies, fermentum lorem sed, condimentum sem." +
                   " Phasellus aliquam, ligula nec placerat hendrerit, urna sapien eleifend purus, fermentum sollicitudin nunc ex eu velit." +
                   " Aenean laoreet, metus a facilisis luctus, eros ligula rhoncus odio, consectetur ornare nunc augue ut mi." +
                   " Integer molestie pellentesque sapien at pharetra. Nunc suscipit lorem vitae ex pretium, at tempor augue iaculis." +
                   " Praesent suscipit placerat mauris eget vehicula. Duis purus enim, sodales eget euismod id, commodo et tellus." +
                   " Mauris sed condimentum augue, vitae tempor ex."
               }
           );

            modelBuilder.Entity<TechnologyElement>().HasData(
                new TechnologyElement()
                {
                    Id = 1,
                    Name = ".Net"
                },
                new TechnologyElement()
                {
                    Id = 2,
                    Name = "Angular",
                },
                new TechnologyElement()
                {
                    Id = 3,
                    Name = "MSSQL",
                },
                new TechnologyElement()
                {
                    Id = 4,
                    Name = "ASP.NET",
                },
                new TechnologyElement()
                {
                    Id = 5,
                    Name = "MySQL",
                },
                new TechnologyElement()
                {
                    Id = 6,
                    Name = "Spring",
                },
                new TechnologyElement()
                {
                    Id = 7,
                    Name = "Hibernate",
                },
                new TechnologyElement()
                {
                    Id = 8,
                    Name = "HTML & CSS",
                },
                new TechnologyElement()
                {
                    Id = 9,
                    Name = "Node",
                },
                new TechnologyElement()
                {
                    Id = 10,
                    Name = "NoSQL",
                },
                new TechnologyElement()
                {
                    Id = 11,
                    Name = "Symfony",
                },
                new TechnologyElement()
                {
                    Id = 12,
                    Name = "PHPUnit",
                },
                new TechnologyElement()
                {
                    Id = 13,
                    Name = "Django",
                },
                new TechnologyElement()
                {
                    Id = 14,
                    Name = "Flask",
                },
                new TechnologyElement()
                {
                    Id = 15,
                    Name = "React",
                }
           );

            modelBuilder.Entity<TechnologyLevel>().HasData(
                new TechnologyLevel()
                {
                    Id = 1,
                    Level = "Nice to have"
                },
                new TechnologyLevel()
                {
                    Id = 2,
                    Level = "Begginer"
                },
                new TechnologyLevel()
                {
                    Id = 3,
                    Level = "Experienced"
                },
                new TechnologyLevel()
                {
                    Id = 4,
                    Level = "Expert"
                }
            );

            modelBuilder.Entity<ProgrammingLanguage>().HasData(
                new ProgrammingLanguage()
                {
                    Id = 1,
                    Name = "C#"
                },
                new ProgrammingLanguage()
                {
                    Id = 2,
                    Name = "Java"
                },
                new ProgrammingLanguage()
                {
                    Id = 3,
                    Name = "JavaScript"
                },
                new ProgrammingLanguage()
                {
                    Id = 4,
                    Name = "PHP"
                },
                new ProgrammingLanguage()
                {
                    Id = 5,
                    Name = "Python"
                }
            );

            modelBuilder.Entity<TechStack>().HasData(
                   new TechStack()
                   {
                       JobOfferId = 1,
                       TechnologyElementId = 1,
                       TechnologyLevelId = 2
                   },
                   new TechStack()
                   {
                       JobOfferId = 1,
                       TechnologyElementId = 1,
                       TechnologyLevelId = 2
                   },
                   new TechStack()
                   {
                       JobOfferId = 1,
                       TechnologyElementId = 4,
                       TechnologyLevelId = 1
                   },
                   new TechStack()
                   {
                       JobOfferId = 1,
                       TechnologyElementId = 3,
                       TechnologyLevelId = 2
                   },
                   new TechStack()
                   {
                       JobOfferId = 1,
                       TechnologyElementId = 4,
                       TechnologyLevelId = 2
                   },

                   new TechStack()
                   {
                       JobOfferId = 2,
                       TechnologyElementId = 1,
                       TechnologyLevelId = 3
                   },
                   new TechStack()
                   {
                       JobOfferId = 2,
                       TechnologyElementId = 1,
                       TechnologyLevelId = 3
                   },
                   new TechStack()
                   {
                       JobOfferId = 2,
                       TechnologyElementId = 2,
                       TechnologyLevelId = 1
                   },
                   new TechStack()
                   {
                       JobOfferId = 2,
                       TechnologyElementId = 3,
                       TechnologyLevelId = 3
                   },
                   new TechStack()
                   {
                       JobOfferId = 2,
                       TechnologyElementId = 4,
                       TechnologyLevelId = 3
                   },

                   new TechStack()
                   {
                       JobOfferId = 3,
                       TechnologyElementId = 1,
                       TechnologyLevelId = 3
                   },
                   new TechStack()
                   {
                       JobOfferId = 3,
                       TechnologyElementId = 1,
                       TechnologyLevelId = 3
                   },
                   new TechStack()
                   {
                       JobOfferId = 3,
                       TechnologyElementId = 4,
                       TechnologyLevelId = 3
                   },
                   new TechStack()
                   {
                       JobOfferId = 3,
                       TechnologyElementId = 3,
                       TechnologyLevelId = 3
                   },
                   new TechStack()
                   {
                       JobOfferId = 3,
                       TechnologyElementId = 4,
                       TechnologyLevelId = 3
                   },

                   new TechStack()
                   {
                       JobOfferId = 4,
                       TechnologyElementId = 3,
                       TechnologyLevelId = 4
                   },
                   new TechStack()
                   {
                       JobOfferId = 4,
                       TechnologyElementId = 6,
                       TechnologyLevelId = 4
                   },
                   new TechStack()
                   {
                       JobOfferId = 4,
                       TechnologyElementId = 7,
                       TechnologyLevelId = 4
                   },
                   new TechStack()
                   {
                       JobOfferId = 4,
                       TechnologyElementId = 5,
                       TechnologyLevelId = 4
                   },

                   new TechStack()
                   {
                       JobOfferId = 5,
                       TechnologyElementId = 3,
                       TechnologyLevelId = 4
                   },
                   new TechStack()
                   {
                       JobOfferId = 5,
                       TechnologyElementId = 6,
                       TechnologyLevelId = 4
                   },
                   new TechStack()
                   {
                       JobOfferId = 5,
                       TechnologyElementId = 7,
                       TechnologyLevelId = 4
                   },
                   new TechStack()
                   {
                       JobOfferId = 5,
                       TechnologyElementId = 5,
                       TechnologyLevelId = 4
                   },

                   new TechStack()
                   {
                       JobOfferId = 6,
                       TechnologyElementId = 3,
                       TechnologyLevelId = 2
                   },
                   new TechStack()
                   {
                       JobOfferId = 6,
                       TechnologyElementId = 4,
                       TechnologyLevelId = 1
                   },
                   new TechStack()
                   {
                       JobOfferId = 6,
                       TechnologyElementId = 8,
                       TechnologyLevelId = 1
                   },
                   new TechStack()
                   {
                       JobOfferId = 6,
                       TechnologyElementId = 6,
                       TechnologyLevelId = 2
                   },
                   new TechStack()
                   {
                       JobOfferId = 6,
                       TechnologyElementId = 7,
                       TechnologyLevelId = 2
                   },
                   new TechStack()
                   {
                       JobOfferId = 6,
                       TechnologyElementId = 5,
                       TechnologyLevelId = 1
                   },

                   new TechStack()
                   {
                       JobOfferId = 7,
                       TechnologyElementId = 15,
                       TechnologyLevelId = 3
                   },
                   new TechStack()
                   {
                       JobOfferId = 7,
                       TechnologyElementId = 2,
                       TechnologyLevelId = 2
                   },
                   new TechStack()
                   {
                       JobOfferId = 7,
                       TechnologyElementId = 8,
                       TechnologyLevelId = 3
                   },
                   new TechStack()
                   {
                       JobOfferId = 7,
                       TechnologyElementId = 4,
                       TechnologyLevelId = 3
                   },

                   new TechStack()
                   {
                       JobOfferId = 8,
                       TechnologyElementId = 15,
                       TechnologyLevelId = 2
                   },
                   new TechStack()
                   {
                       JobOfferId = 8,
                       TechnologyElementId = 4,
                       TechnologyLevelId = 2
                   },
                   new TechStack()
                   {
                       JobOfferId = 8,
                       TechnologyElementId = 8,
                       TechnologyLevelId = 2
                   },
                   new TechStack()
                   {
                       JobOfferId = 8,
                       TechnologyElementId = 9,
                       TechnologyLevelId = 1
                   },
                   new TechStack()
                   {
                       JobOfferId = 8,
                       TechnologyElementId = 10,
                       TechnologyLevelId = 1
                   },

                   new TechStack()
                   {
                       JobOfferId = 9,
                       TechnologyElementId = 15,
                       TechnologyLevelId = 3
                   },
                   new TechStack()
                   {
                       JobOfferId = 9,
                       TechnologyElementId = 4,
                       TechnologyLevelId = 3
                   },
                   new TechStack()
                   {
                       JobOfferId = 9,
                       TechnologyElementId = 8,
                       TechnologyLevelId = 3
                   },
                   new TechStack()
                   {
                       JobOfferId = 9,
                       TechnologyElementId = 9,
                       TechnologyLevelId = 3
                   },
                   new TechStack()
                   {
                       JobOfferId = 9,
                       TechnologyElementId = 10,
                       TechnologyLevelId = 3
                   },

                   new TechStack()
                   {
                       JobOfferId = 10,
                       TechnologyElementId = 2,
                       TechnologyLevelId = 3
                   },
                   new TechStack()
                   {
                       JobOfferId = 10,
                       TechnologyElementId = 4,
                       TechnologyLevelId = 3
                   },
                   new TechStack()
                   {
                       JobOfferId = 10,
                       TechnologyElementId = 8,
                       TechnologyLevelId = 3
                   },
                   new TechStack()
                   {
                       JobOfferId = 10,
                       TechnologyElementId = 9,
                       TechnologyLevelId = 3
                   },
                   new TechStack()
                   {
                       JobOfferId = 10,
                       TechnologyElementId = 10,
                       TechnologyLevelId = 3
                   },

                   new TechStack()
                   {
                       JobOfferId = 11,
                       TechnologyElementId = 13,
                       TechnologyLevelId = 3
                   },
                   new TechStack()
                   {
                       JobOfferId = 11,
                       TechnologyElementId = 14,
                       TechnologyLevelId = 3
                   },
                   new TechStack()
                   {
                       JobOfferId = 11,
                       TechnologyElementId = 5,
                       TechnologyLevelId = 3
                   },
                   new TechStack()
                   {
                       JobOfferId = 11,
                       TechnologyElementId = 5,
                       TechnologyLevelId = 3
                   },

                   new TechStack()
                   {
                       JobOfferId = 12,
                       TechnologyElementId = 6,
                       TechnologyLevelId = 2
                   },
                   new TechStack()
                   {
                       JobOfferId = 12,
                       TechnologyElementId = 5,
                       TechnologyLevelId = 2
                   },
                   new TechStack()
                   {
                       JobOfferId = 12,
                       TechnologyElementId = 11,
                       TechnologyLevelId = 2
                   },
                   new TechStack()
                   {
                       JobOfferId = 12,
                       TechnologyElementId = 12,
                       TechnologyLevelId = 2
                   }
           );

        }
    }
}
