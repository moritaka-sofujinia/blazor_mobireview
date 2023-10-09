using Microsoft.EntityFrameworkCore;

namespace DoAnCS_Demo1.Data
{
    public class UserContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public UserContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(Configuration.GetConnectionString("DataDB"));
        }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<User>().HasData(
                    new User
                    {
                        Id = 1,
                        username = "cfillery0",
                        password = "rbenrnju)K1R7r'",
                        name = "Correy Fillery",
                        email = "cfillery0@hubpages.com"
                    },
                    new User
                    {
                        Id = 2,
                        username = "cninnis1",
                        password = "avfaxpxu?9!D4'",
                        name = "Casandra Ninnis",
                        email = "cninnis1@sogou.com"
                    },
                    new User
                    {
                        Id = 3,
                        username = "wwhitely2",
                        password = "jclrsecgA",
                        name = "Wiley Whitely",
                        email = "wwhitely2@businesswire.com"
                    },
                    new User
                    {
                        Id = 4,
                        username = "cberwick3",
                        password = "ihwzuavt",
                        name = "Candice Berwick",
                        email = "cberwick3@constantcontact.com"
                    },
                    new User
                    {
                        Id = 5,
                        username = "bmarden4",
                        password = "uurxsltd1",
                        name = "Beret Marden",
                        email = "bmarden4@linkedin.com"
                    },
                    new User
                    {
                        Id = 6,
                        username = "ajudge5",
                        password = "lcehggcko",
                        name = "Alvis Judge",
                        email = "ajudge5@privacy.gov.au"
                    },
                    new User
                    {
                        Id = 7,
                        username = "laneley6",
                        password = "mgkebjqu",
                        name = "Lemuel Aneley",
                        email = "laneley6@wikispaces.com"
                    },
                    new User
                    {
                        Id = 8,
                        username = "ikilford7",
                        password = "dkneunzk*5vYc",
                        name = "Ines Kilford",
                        email = "ikilford7@nationalgeographic.com"
                    },
                    new User
                    {
                        Id = 9,
                        username = "sschollick8",
                        password = "cnwqiswsPjl6/8u/",
                        name = "Shannan Schollick",
                        email = "sschollick8@hud.gov"
                    },
                    new User
                    {
                        Id = 10,
                        username = "rweson9",
                        password = "wmwjhubsb",
                        name = "Rozanne Weson",
                        email = "rweson9@list-manage.com"
                    },
                    new User
                    {
                        Id = 11,
                        username = "cbolzena",
                        password = "sdnsdtpsZ8&|P@Zu",
                        name = "Ches Bolzen",
                        email = "cbolzena@techcrunch.com"
                    },
                    new User
                    {
                        Id = 12,
                        username = "fohickeeb",
                        password = "rfbygomr6AF9j",
                        name = "Filippo O'Hickee",
                        email = "fohickeeb@quantcast.com"
                    },
                    new User
                    {
                        Id = 13,
                        username = "tdomeganc",
                        password = "hzityiykZ",
                        name = "Teresa Domegan",
                        email = "tdomeganc@instagram.com"
                    },
                    new User
                    {
                        Id = 14,
                        username = "smacalpined",
                        password = "kbvulodh",
                        name = "Salmon MacAlpine",
                        email = "salmonmacalpine@gmail.com"
                    },
                    new User
                    {
                        Id = 15,
                        username = "vgiereke",
                        password = "ulwvqthf.",
                        name = "Valentin Gierek",
                        email = "vgiereke@msu.edu"
                    },
                    new User
                    {
                        Id = 16,
                        username = "hduthief",
                        password = "wtlpzxqe`=1ek*QU",
                        name = "Horten Duthie",
                        email = "hduthief@goo.gl"
                    },
                    new User
                    {
                        Id = 17,
                        username = "hhengoedg",
                        password = "owraixrwl*_~Pu",
                        name = "Holt Hengoed",
                        email = "hhengoedg@twitter.com"
                    },
                    new User
                    {
                        Id = 18,
                        username = "rsacaseh",
                        password = "nyimvjgeH5&_m",
                        name = "Renae Sacase",
                        email = "rsacaseh@ezinearticles.com"
                    },
                    new User
                    {
                        Id = 19,
                        username = "egreystokei",
                        password = "etysnblfN",
                        name = "Ethelda Greystoke",
                        email = "egreystokei@pagesperso-orange.fr"
                    },
                    new User
                    {
                        Id = 20,
                        username = "hborgbartoloj",
                        password = "twfrouhb&.lZ/LWH",
                        name = "Hazel Borg-Bartolo",
                        email = "hborgbartoloj@netlog.com"
                    }
                );
        }
    }
}
