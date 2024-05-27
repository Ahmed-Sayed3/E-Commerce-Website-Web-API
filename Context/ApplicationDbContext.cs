namespace E_Commerce_C_.Context
{
    public class ApplicationDbContext: IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {

        }

        //Db Sets To Create Table In Db
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetails> orderDetails { get; set; }


        // Product Data 
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Fjallraven - Foldsack No. 1 Backpack, Fits 15 Laptops",
                Description = "Your perfect pack for everyday use and walks in the forest. Stash your laptop (up to 15 inches) in the padded sleeve, your everyday",
                Category = "men's clothing",
                Price = 109.95,
                Image = "https://fakestoreapi.com/img/81fPKd-2AYL._AC_SL1500_.jpg",
            }, new Product
            {
                Id = 2,
                Name = "Mens Casual Premium Slim Fit T-Shirts ",
                Description = "Slim-fitting style, contrast raglan long sleeve, three-button henley placket, light weight & soft fabric for breathable and comfortable wearing. And Solid stitched shirts with round neck made for durability and a great fit for casual fashion wear and diehard baseball fans. The Henley style round neckline includes a three-button placket.",
                Category = "men's clothing",
                Price = 22.3,
                Image = "https://fakestoreapi.com/img/71-3HjGNDUL._AC_SY879._SX._UX._SY._UY_.jpg",
            }, new Product
            {
                Id = 3,
                Name = "Mens Cotton Jacket",
                Description = "great outerwear jackets for Spring/Autumn/Winter, suitable for many occasions, such as working, hiking, camping, mountain/rock climbing, cycling, traveling or other outdoors. Good gift choice for you or your family member. A warm hearted love to Father, husband or son in this thanksgiving or Christmas Day.",
                Category = "men's clothing",
                Price = 55.99,
                Image = "https://fakestoreapi.com/img/71li-ujtlUL._AC_UX679_.jpg",
            }, new Product
            {
                Id = 4,
                Name = "Mens Casual Slim Fit",
                Description = "The color could be slightly different between on the screen and in practice. / Please note that body builds vary by person, therefore, detailed size information should be reviewed below on the product description.",
                Category = "men's clothing",
                Price = 15.99,
                Image = "https://fakestoreapi.com/img/71YXzeOuslL._AC_UY879_.jpg",
            }, new Product
            {
                Id = 5,
                Name = "John Hardy Women's Legends Naga Gold & Silver Dragon Station Chain Bracelet",
                Description = "From our Legends Collection, the Naga was inspired by the mythical water dragon that protects the ocean's pearl. Wear facing inward to be bestowed with love and abundance, or outward for protection.",
                Category = "jewelery",
                Price = 695,
                Image = "https://fakestoreapi.com/img/71pWzhdJNwL._AC_UL640_QL65_ML3_.jpg",
            }, new Product
            {
                Id = 6,
                Name = "Solid Gold Petite Micropave ",
                Description = "Satisfaction Guaranteed. Return or exchange any order within 30 days.Designed and sold by Hafeez Center in the United States. Satisfaction Guaranteed. Return or exchange any order within 30 days.",
                Category = "jewelery",
                Price = 168,
                Image = "https://fakestoreapi.com/img/61sbMiUnoGL._AC_UL640_QL65_ML3_.jpg",
            }, new Product
            {
                Id = 7,
                Name = "White Gold Plated Princess",
                Description = "Classic Created Wedding Engagement Solitaire Diamond Promise Ring for Her. Gifts to spoil your love more for Engagement, Wedding, Anniversary, Valentine's Day...",
                Category = "jewelery",
                Price = 9.99,
                Image = "https://fakestoreapi.com/img/71YAIFU48IL._AC_UL640_QL65_ML3_.jpg",
            }, new Product
            {
                Id = 8,
                Name = "Pierced Owl Rose Gold Plated Stainless Steel Double",
                Description = "Rose Gold Plated Double Flared Tunnel Plug Earrings. Made of 316L Stainless Steel",
                Category = "jewelery",
                Price = 10.99,
                Image = "https://fakestoreapi.com/img/51UDEzMJVpL._AC_UL640_QL65_ML3_.jpg",
            }, new Product
            {
                Id = 9,
                Name = "WD 2TB Elements Portable External Hard Drive - USB 3.0 ",
                Description = "USB 3.0 and USB 2.0 Compatibility Fast data transfers Improve PC Performance High Capacity; Compatibility Formatted NTFS for Windows 10, Windows 8.1, Windows 7; Reformatting may be required for other operating systems; Compatibility may vary depending on user’s hardware configuration and operating system",
                Category = "electronics",
                Price = 64,
                Image = "https://fakestoreapi.com/img/61IBBVJvSDL._AC_SY879_.jpg",
            }, new Product
            {
                Id = 10,
                Name = "SanDisk SSD PLUS 1TB Internal SSD - SATA III 6 Gb/s",
                Description = "Easy upgrade for faster boot up, shutdown, application load and response (As compared to 5400 RPM SATA 2.5” hard drive; Based on published specifications and internal benchmarking tests using PCMark vantage scores) Boosts burst write performance, making it ideal for typical PC workloads The perfect balance of performance and reliability Read/write speeds of up to 535MB/s/450MB/s (Based on internal testing; Performance may vary depending upon drive capacity, host device, OS and application.)",
                Category = "electronics",
                Price = 109,
                Image = "https://fakestoreapi.com/img/61U7T1koQqL._AC_SX679_.jpg",
            }, new Product
            {
                Id = 11,
                Name = "Silicon Power 256GB SSD 3D NAND A55 SLC Cache Performance Boost SATA III 2.5",
                Description = "3D NAND flash are applied to deliver high transfer speeds Remarkable transfer speeds that enable faster bootup and improved overall system performance. The advanced SLC Cache Technology allows performance boost and longer lifespan 7mm slim design suitable for Ultrabooks and Ultra-slim notebooks. Supports TRIM command, Garbage Collection technology, RAID, and ECC (Error Checking & Correction) to provide the optimized performance and enhanced reliability.",
                Category = "electronics",
                Price = 109,
                Image = "https://fakestoreapi.com/img/71kWymZ+c+L._AC_SX679_.jpg",
            }, new Product
            {
                Id = 12,
                Name = "WD 4TB Gaming Drive Works with Playstation 4 Portable External Hard Drive",
                Description = "Expand your PS4 gaming experience, Play anywhere Fast and easy, setup Sleek design with high capacity, 3-year manufacturer's limited warranty",
                Category = "electronics",
                Price = 114,
                Image = "https://fakestoreapi.com/img/61mtL65D4cL._AC_SX679_.jpg",
            },new Product
            {
                Id = 13,
                Name = "Acer SB220Q bi 21.5 inches Full HD (1920 x 1080) IPS Ultra-Thin",
                Description = "21. 5 inches Full HD (1920 x 1080) widescreen IPS display And Radeon free Sync technology. No compatibility for VESA Mount Refresh Rate= 75Hz - Using HDMI port Zero-frame design | ultra-thin | 4ms response time | IPS panel Aspect ratio - 16= 9. Color Supported - 16. 7 million colors. Brightness - 250 nit Tilt angle -5 degree to 15 degree. Horizontal viewing angle-178 degree. Vertical viewing angle-178 degree 75 hertz",
                Category = "electronics",
                Price = 599,
                Image = "https://fakestoreapi.com/img/81QpkIctqPL._AC_SX679_.jpg",
            }, new Product
            {
                Id = 14,
                Name = "Samsung 49-Inch CHG90 144Hz Curved Gaming Monitor (LC49HG90DMNXZA) – Super Ultrawide Screen QLED ",
                Description = "49 INCH SUPER ULTRAWIDE 32=9 CURVED GAMING MONITOR with dual 27 inch screen side by side QUANTUM DOT (QLED) TECHNOLOGY, HDR support and factory calibration provides stunningly realistic and accurate color and contrast 144HZ HIGH REFRESH RATE and 1ms ultra fast response time work to eliminate motion blur, ghosting, and reduce input lag",
                Category = "electronics",
                Price = 999.99,
                Image = "https://fakestoreapi.com/img/81Zt42ioCgL._AC_SX679_.jpg",
            }, new Product
            {
                Id = 15,
                Name = "BIYLACLESEN Women's 3-in-1 Snowboard Jacket Winter Coats",
                Description = "Note=The Jackets is US standard size, Please choose size as your usual wear Material= 100% Polyester; Detachable Liner Fabric= Warm Fleece. Detachable Functional Liner= Skin Friendly, Lightweigt and Warm.Stand Collar Liner jacket, keep you warm in cold weather. Zippered Pockets= 2 Zippered Hand Pockets, 2 Zippered Pockets on Chest (enough to keep cards or keys)and 1 Hidden Pocket Inside.Zippered Hand Pockets and Hidden Pocket keep your things secure. Humanized Design= Adjustable and Detachable Hood and Adjustable cuff to prevent the wind and water,for a comfortable fit. 3 in 1 Detachable Design provide more convenience, you can separate the coat and inner as needed, or wear it together. It is suitable for different season and help you adapt to different climates",
                Category = "women's clothing",
                Price = 56.99,
                Image = "https://fakestoreapi.com/img/51Y5NI-I5jL._AC_UX679_.jpg",
            }, new Product
            {
                Id = 16,
                Name = "Lock and Love Women's Removable Hooded Faux Leather Moto Biker Jacket",
                Price = 29.95,
                Description = "100% POLYURETHANE(shell) 100% POLYESTER(lining) 75% POLYESTER 25% COTTON (SWEATER), Faux leather material for style and comfort / 2 pockets of front, 2-For-One Hooded denim style faux leather jacket, Button detail on waist / Detail stitching at sides, HAND WASH ONLY / DO NOT BLEACH / LINE DRY / DO NOT IRON",
                Category = "women's clothing",
                Image = "https://fakestoreapi.com/img/81XH0e8fefL._AC_UY879_.jpg",
            }, new Product
            {
                Id = 17,
                Name = "Rain Jacket Women Windbreaker Striped Climbing Raincoats",
                Price = 39.99,
                Description = "Lightweight perfet for trip or casual wear---Long sleeve with hooded, adjustable drawstring waist design. Button and zipper front closure raincoat, fully stripes Lined and The Raincoat has 2 side pockets are a good size to hold all kinds of things, it covers the hips, and the hood is generous but doesn't overdo it.Attached Cotton Lined Hood with Adjustable Drawstrings give it a real styled look.",
                Category = "women's clothing",
                Image = "https://fakestoreapi.com/img/71HblAHs5xL._AC_UY879_-2.jpg",
            }, new Product
            {
                Id = 18,
                Name = "MBJ Women's Solid Short Sleeve Boat Neck V ",
                Description = "95% RAYON 5% SPANDEX, Made in USA or Imported, Do Not Bleach, Lightweight fabric with great stretch for comfort, Ribbed on sleeves and neckline / Double stitching on bottom hem",
                Category = "women's clothing",
                Price = 9.85,
                Image = "https://fakestoreapi.com/img/71z3kpMAYsL._AC_UY879_.jpg",
            }, new Product
            {
                Id = 19,
                Name = "Opna Women's Short Sleeve Moisture",
                Description = "100% Polyester, Machine wash, 100% cationic polyester interlock, Machine Wash & Pre Shrunk for a Great Fit, Lightweight, roomy and highly breathable with moisture wicking fabric which helps to keep moisture away, Soft Lightweight Fabric with comfortable V-neck collar and a slimmer fit, delivers a sleek, more feminine silhouette and Added Comfort",
                Category = "women's clothing",
                Price = 7.95,
                Image = "https://fakestoreapi.com/img/51eg55uWmdL._AC_UX679_.jpg",
            }, new Product
            {
                Id = 20,
                Name = "DANVOUY Womens T Shirt Casual Cotton Short",
                Description = "95%Cotton,5%Spandex, Features= Casual, Short Sleeve, Letter Print,V-Neck,Fashion Tees, The fabric is soft and has some stretch., Occasion= Casual/Office/Beach/School/Home/Street. Season= Spring,Summer,Autumn,Winter.",
                Category = "women's clothing",
                Price = 12.99,
                Image = "https://fakestoreapi.com/img/61pHAEJ4NML._AC_UX679_.jpg",
            }, new Product
            {
                Id = 21,
                Name = "iPhone 9",
                Description = "An apple mobile which is nothing like apple",
                Category = "smartphones",
                Price = 549,
                Image = "https://d57avc95tvxyg.cloudfront.net/images/thumbnails/400/400/detailed/2449/full_body_housing_for_apple_iphone_9_white_maxbhi.com_41205.jpg?t=1700812354"
            }, new Product
            {
                Id = 22,
                Name = "iPhone X",
                Description = "SIM-Free, Model A19211 6.5-inch Super Retina HD display with OLED technology A12 Bionic chip with ...",
                Category = "smartphones",
                Price = 899,
                Image = "https://d57avc95tvxyg.cloudfront.net/images/thumbnails/761/761/detailed/2884/full_body_housing_for_apple_iphone_x_plus_gold_maxbhi_com_40666.jpg?t=1700821762"
            }, new Product
            {
                Id = 23,
                Name = "Samsung Universe 9",
                Description = "Samsung's new variant which goes beyond Galaxy to the Universe",
                Category = "smartphones",
                Price = 1249,
                Image = "https://pbs.twimg.com/media/Dr2wz4AU4AEXQeN?format=jpg&name=900x900"
            }, new Product
            {
                Id = 24,
                Name = "OPPOF19",
                Description = "OPPO F19 is officially announced on April 2021.",
                Category = "smartphones",
                Price = 280,
                Image = "https://imei.org/storage/files/images/6343/preview/oppo-f19-1.png"
            }, new Product
            {
                Id = 25,
                Name = "Huawei P30",
                Description = "Huawei’s re-badged P30 Pro New Edition was officially unveiled yesterday in Germany and now the device has made its way to the UK.",
                Category = "smartphones",
                Price = 499,
                Image = "https://m.media-amazon.com/images/I/61TsiAtMVQL._AC_SL1000_.jpg"
            }, new Product
            {
                Id = 26,
                Name = "MacBook Pro",
                Description = "MacBook Pro 2021 with mini-LED display may launch between September, November",
                Category = "laptops",
                Price = 1749,
                Image = "https://m.media-amazon.com/images/I/615mtxVd8+L._AC_SL1500_.jpg"
            }, new Product
            {
                Id = 27,
                Name = "Samsung Galaxy Book",
                Description = "Samsung Galaxy Book S (2020) Laptop With Intel Lakefield Chip, 8GB of RAM Launched",
                Category = "laptops",
                Price = 1499,
                Image = "https://i5.walmartimages.com/seo/SAMSUNG-Galaxy-Book-Go-14-FHD-Laptop-4GB-Memory-64GB-HD-Silver-Windows-11_6b6b54f5-fa78-4278-a752-6e5166a7f161.3118788ed16fe26fbd733a82ae739e78.jpeg"
            }, new Product
            {
                Id = 28,
                Name = "Microsoft Surface Laptop 4",
                Description = "Style and speed. Stand out on HD video calls backed by Studio Mics. Capture ideas on the vibrant touchscreen.",
                Category = "laptops",
                Price = 1499,
                Image = "https://i5.walmartimages.com/seo/SAMSUNG-Galaxy-Book-Go-14-FHD-Laptop-4GB-Memory-64GB-HD-Silver-Windows-11_6b6b54f5-fa78-4278-a752-6e5166a7f161.3118788ed16fe26fbd733a82ae739e78.jpeg"
            }, new Product
            {
                Id = 29,
                Name = "Infinix INBOOK",
                Description = "Infinix Inbook X1 Ci3 10th 8GB 256GB 14 Win10 Grey – 1 Year Warranty",
                Category = "laptops",
                Price = 1099,
                Image = "https://m.media-amazon.com/images/I/71vnokFltKL._AC_SX679_.jpg"
            }, new Product
            {
                Id = 30,
                Name = "HP Pavilion 15-DK1056WM",
                Description = "HP Pavilion 15-DK1056WM Gaming Laptop 10th Gen Core i5, 8GB, 256GB SSD, GTX 1650 4GB, Windows 10",
                Category = "laptops",
                Price = 1099,
                Image = "https://i5.walmartimages.com/seo/HP-Pavilion-15-6-FHD-Gaming-Laptop-Intel-Core-i5-10300H-8GB-RAM-NVIDIA-GeForce-GTX-1650-4GB-250GB-SSD-Windows-10-Home-Black-15-dk1056wm_8b269d16-6343-40c0-832f-e4d394ad8b75.9a1d5beb1ed0c4b7815d8657536428f9.jpeg"
            });
        }


    }
}
