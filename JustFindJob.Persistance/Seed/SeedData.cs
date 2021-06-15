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

            modelBuilder.Entity<Technology>().HasData(
                new Technology()
                {
                    Id = 1,
                    JobOfferId = 1,
                    MainTechnologyName = ".Net",
                },
                new Technology()
                {
                    Id = 2,
                    JobOfferId = 2,
                    MainTechnologyName = ".Net"
                },
                new Technology()
                {
                    Id = 3,
                    JobOfferId = 3,
                    MainTechnologyName = ".Net"
                },
                new Technology()
                {
                    Id = 4,
                    JobOfferId = 4,
                    MainTechnologyName = "Java"
                },
                new Technology()
                {
                    Id = 5,
                    JobOfferId = 5,
                    MainTechnologyName = "Java"
                },
                new Technology()
                {
                    Id = 6,
                    JobOfferId = 6,
                    MainTechnologyName = "Java"
                },
                new Technology()
                {
                    Id = 7,
                    JobOfferId = 7,
                    MainTechnologyName = "Java"
                },
                new Technology()
                {
                    Id = 8,
                    JobOfferId = 8,
                    MainTechnologyName = "JavaScript"
                },
                new Technology()
                {
                    Id = 9,
                    JobOfferId = 9,
                    MainTechnologyName = "JavaScript"
                },
                new Technology()
                {
                    Id = 10,
                    JobOfferId = 10,
                    MainTechnologyName = "JavaScript"
                },
                new Technology()
                {
                    Id = 11,
                    JobOfferId = 11,
                    MainTechnologyName = "PHP"
                },
                new Technology()
                {
                    Id = 12,
                    JobOfferId = 12,
                    MainTechnologyName = "Python"
                }
           );

            modelBuilder.Entity<TechnologyElement>().HasData(
                new TechnologyElement()
                {
                    Id = 1,
                    TechnologyId = 1,
                    ElementName = "ASP.NET",
                    ElementLevel = "Junior"
                },
                new TechnologyElement()
                {
                    Id = 2,
                    TechnologyId = 1,
                    ElementName = "Angular",
                    ElementLevel = "Junior"
                },
                new TechnologyElement()
                {
                    Id = 3,
                    TechnologyId = 1,
                    ElementName = "MSSQL",
                    ElementLevel = "Junior"
                },
                new TechnologyElement()
                {
                    Id = 4,
                    TechnologyId = 2,
                    ElementName = "ASP.NET",
                    ElementLevel = "Mid"
                },
                new TechnologyElement()
                {
                    Id = 5,
                    TechnologyId = 2,
                    ElementName = "Angular",
                    ElementLevel = "Junior"
                },
                new TechnologyElement()
                {
                    Id = 6,
                    TechnologyId = 2,
                    ElementName = "MSSQL",
                    ElementLevel = "Mid"
                },
                new TechnologyElement()
                {
                    Id = 7,
                    TechnologyId = 3,
                    ElementName = "ASP.NET",
                    ElementLevel = "Mid"
                },
                new TechnologyElement()
                {
                    Id = 8,
                    TechnologyId = 3,
                    ElementName = "Angular",
                    ElementLevel = "Mid"
                },
                new TechnologyElement()
                {
                    Id = 9,
                    TechnologyId = 3,
                    ElementName = "MSSQL",
                    ElementLevel = "Mid"
                },
                new TechnologyElement()
                {
                    Id = 10,
                    TechnologyId = 3,
                    ElementName = "MySQL",
                    ElementLevel = "Senior"
                },
                new TechnologyElement()
                {
                    Id = 11,
                    TechnologyId = 3,
                    ElementName = "Spring",
                    ElementLevel = "Senior"
                },
                new TechnologyElement()
                {
                    Id = 12,
                    TechnologyId = 3,
                    ElementName = "Hibernate",
                    ElementLevel = "Senior"
                }
           );
        }
    }
}
