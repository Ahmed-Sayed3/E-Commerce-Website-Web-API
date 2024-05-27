using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E_Commerce_C_.Migrations
{
    /// <inheritdoc />
    public partial class productdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SpecialTag",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[,]
                {
                    { 1, "men's clothing", "Your perfect pack for everyday use and walks in the forest. Stash your laptop (up to 15 inches) in the padded sleeve, your everyday", "https://fakestoreapi.com/img/81fPKd-2AYL._AC_SL1500_.jpg", "Fjallraven - Foldsack No. 1 Backpack, Fits 15 Laptops", 109.95, null },
                    { 2, "men's clothing", "Slim-fitting style, contrast raglan long sleeve, three-button henley placket, light weight & soft fabric for breathable and comfortable wearing. And Solid stitched shirts with round neck made for durability and a great fit for casual fashion wear and diehard baseball fans. The Henley style round neckline includes a three-button placket.", "https://fakestoreapi.com/img/71-3HjGNDUL._AC_SY879._SX._UX._SY._UY_.jpg", "Mens Casual Premium Slim Fit T-Shirts ", 22.300000000000001, null },
                    { 3, "men's clothing", "great outerwear jackets for Spring/Autumn/Winter, suitable for many occasions, such as working, hiking, camping, mountain/rock climbing, cycling, traveling or other outdoors. Good gift choice for you or your family member. A warm hearted love to Father, husband or son in this thanksgiving or Christmas Day.", "https://fakestoreapi.com/img/71li-ujtlUL._AC_UX679_.jpg", "Mens Cotton Jacket", 55.990000000000002, null },
                    { 4, "men's clothing", "The color could be slightly different between on the screen and in practice. / Please note that body builds vary by person, therefore, detailed size information should be reviewed below on the product description.", "https://fakestoreapi.com/img/71YXzeOuslL._AC_UY879_.jpg", "Mens Casual Slim Fit", 15.99, null },
                    { 5, "jewelery", "From our Legends Collection, the Naga was inspired by the mythical water dragon that protects the ocean's pearl. Wear facing inward to be bestowed with love and abundance, or outward for protection.", "https://fakestoreapi.com/img/71pWzhdJNwL._AC_UL640_QL65_ML3_.jpg", "John Hardy Women's Legends Naga Gold & Silver Dragon Station Chain Bracelet", 695.0, null },
                    { 6, "jewelery", "Satisfaction Guaranteed. Return or exchange any order within 30 days.Designed and sold by Hafeez Center in the United States. Satisfaction Guaranteed. Return or exchange any order within 30 days.", "https://fakestoreapi.com/img/61sbMiUnoGL._AC_UL640_QL65_ML3_.jpg", "Solid Gold Petite Micropave ", 168.0, null },
                    { 7, "jewelery", "Classic Created Wedding Engagement Solitaire Diamond Promise Ring for Her. Gifts to spoil your love more for Engagement, Wedding, Anniversary, Valentine's Day...", "https://fakestoreapi.com/img/71YAIFU48IL._AC_UL640_QL65_ML3_.jpg", "White Gold Plated Princess", 9.9900000000000002, null },
                    { 8, "jewelery", "Rose Gold Plated Double Flared Tunnel Plug Earrings. Made of 316L Stainless Steel", "https://fakestoreapi.com/img/51UDEzMJVpL._AC_UL640_QL65_ML3_.jpg", "Pierced Owl Rose Gold Plated Stainless Steel Double", 10.99, null },
                    { 9, "electronics", "USB 3.0 and USB 2.0 Compatibility Fast data transfers Improve PC Performance High Capacity; Compatibility Formatted NTFS for Windows 10, Windows 8.1, Windows 7; Reformatting may be required for other operating systems; Compatibility may vary depending on user’s hardware configuration and operating system", "https://fakestoreapi.com/img/61IBBVJvSDL._AC_SY879_.jpg", "WD 2TB Elements Portable External Hard Drive - USB 3.0 ", 64.0, null },
                    { 10, "electronics", "Easy upgrade for faster boot up, shutdown, application load and response (As compared to 5400 RPM SATA 2.5” hard drive; Based on published specifications and internal benchmarking tests using PCMark vantage scores) Boosts burst write performance, making it ideal for typical PC workloads The perfect balance of performance and reliability Read/write speeds of up to 535MB/s/450MB/s (Based on internal testing; Performance may vary depending upon drive capacity, host device, OS and application.)", "https://fakestoreapi.com/img/61U7T1koQqL._AC_SX679_.jpg", "SanDisk SSD PLUS 1TB Internal SSD - SATA III 6 Gb/s", 109.0, null },
                    { 11, "electronics", "3D NAND flash are applied to deliver high transfer speeds Remarkable transfer speeds that enable faster bootup and improved overall system performance. The advanced SLC Cache Technology allows performance boost and longer lifespan 7mm slim design suitable for Ultrabooks and Ultra-slim notebooks. Supports TRIM command, Garbage Collection technology, RAID, and ECC (Error Checking & Correction) to provide the optimized performance and enhanced reliability.", "https://fakestoreapi.com/img/71kWymZ+c+L._AC_SX679_.jpg", "Silicon Power 256GB SSD 3D NAND A55 SLC Cache Performance Boost SATA III 2.5", 109.0, null },
                    { 12, "electronics", "Expand your PS4 gaming experience, Play anywhere Fast and easy, setup Sleek design with high capacity, 3-year manufacturer's limited warranty", "https://fakestoreapi.com/img/61mtL65D4cL._AC_SX679_.jpg", "WD 4TB Gaming Drive Works with Playstation 4 Portable External Hard Drive", 114.0, null },
                    { 13, "electronics", "21. 5 inches Full HD (1920 x 1080) widescreen IPS display And Radeon free Sync technology. No compatibility for VESA Mount Refresh Rate= 75Hz - Using HDMI port Zero-frame design | ultra-thin | 4ms response time | IPS panel Aspect ratio - 16= 9. Color Supported - 16. 7 million colors. Brightness - 250 nit Tilt angle -5 degree to 15 degree. Horizontal viewing angle-178 degree. Vertical viewing angle-178 degree 75 hertz", "https://fakestoreapi.com/img/81QpkIctqPL._AC_SX679_.jpg", "Acer SB220Q bi 21.5 inches Full HD (1920 x 1080) IPS Ultra-Thin", 599.0, null },
                    { 14, "electronics", "49 INCH SUPER ULTRAWIDE 32=9 CURVED GAMING MONITOR with dual 27 inch screen side by side QUANTUM DOT (QLED) TECHNOLOGY, HDR support and factory calibration provides stunningly realistic and accurate color and contrast 144HZ HIGH REFRESH RATE and 1ms ultra fast response time work to eliminate motion blur, ghosting, and reduce input lag", "https://fakestoreapi.com/img/81Zt42ioCgL._AC_SX679_.jpg", "Samsung 49-Inch CHG90 144Hz Curved Gaming Monitor (LC49HG90DMNXZA) – Super Ultrawide Screen QLED ", 999.99000000000001, null },
                    { 15, "women's clothing", "Note=The Jackets is US standard size, Please choose size as your usual wear Material= 100% Polyester; Detachable Liner Fabric= Warm Fleece. Detachable Functional Liner= Skin Friendly, Lightweigt and Warm.Stand Collar Liner jacket, keep you warm in cold weather. Zippered Pockets= 2 Zippered Hand Pockets, 2 Zippered Pockets on Chest (enough to keep cards or keys)and 1 Hidden Pocket Inside.Zippered Hand Pockets and Hidden Pocket keep your things secure. Humanized Design= Adjustable and Detachable Hood and Adjustable cuff to prevent the wind and water,for a comfortable fit. 3 in 1 Detachable Design provide more convenience, you can separate the coat and inner as needed, or wear it together. It is suitable for different season and help you adapt to different climates", "https://fakestoreapi.com/img/51Y5NI-I5jL._AC_UX679_.jpg", "BIYLACLESEN Women's 3-in-1 Snowboard Jacket Winter Coats", 56.990000000000002, null },
                    { 16, "women's clothing", "100% POLYURETHANE(shell) 100% POLYESTER(lining) 75% POLYESTER 25% COTTON (SWEATER), Faux leather material for style and comfort / 2 pockets of front, 2-For-One Hooded denim style faux leather jacket, Button detail on waist / Detail stitching at sides, HAND WASH ONLY / DO NOT BLEACH / LINE DRY / DO NOT IRON", "https://fakestoreapi.com/img/81XH0e8fefL._AC_UY879_.jpg", "Lock and Love Women's Removable Hooded Faux Leather Moto Biker Jacket", 29.949999999999999, null },
                    { 17, "women's clothing", "Lightweight perfet for trip or casual wear---Long sleeve with hooded, adjustable drawstring waist design. Button and zipper front closure raincoat, fully stripes Lined and The Raincoat has 2 side pockets are a good size to hold all kinds of things, it covers the hips, and the hood is generous but doesn't overdo it.Attached Cotton Lined Hood with Adjustable Drawstrings give it a real styled look.", "https://fakestoreapi.com/img/71HblAHs5xL._AC_UY879_-2.jpg", "Rain Jacket Women Windbreaker Striped Climbing Raincoats", 39.990000000000002, null },
                    { 18, "women's clothing", "95% RAYON 5% SPANDEX, Made in USA or Imported, Do Not Bleach, Lightweight fabric with great stretch for comfort, Ribbed on sleeves and neckline / Double stitching on bottom hem", "https://fakestoreapi.com/img/71z3kpMAYsL._AC_UY879_.jpg", "MBJ Women's Solid Short Sleeve Boat Neck V ", 9.8499999999999996, null },
                    { 19, "women's clothing", "100% Polyester, Machine wash, 100% cationic polyester interlock, Machine Wash & Pre Shrunk for a Great Fit, Lightweight, roomy and highly breathable with moisture wicking fabric which helps to keep moisture away, Soft Lightweight Fabric with comfortable V-neck collar and a slimmer fit, delivers a sleek, more feminine silhouette and Added Comfort", "https://fakestoreapi.com/img/51eg55uWmdL._AC_UX679_.jpg", "Opna Women's Short Sleeve Moisture", 7.9500000000000002, null },
                    { 20, "women's clothing", "95%Cotton,5%Spandex, Features= Casual, Short Sleeve, Letter Print,V-Neck,Fashion Tees, The fabric is soft and has some stretch., Occasion= Casual/Office/Beach/School/Home/Street. Season= Spring,Summer,Autumn,Winter.", "https://fakestoreapi.com/img/61pHAEJ4NML._AC_UX679_.jpg", "DANVOUY Womens T Shirt Casual Cotton Short", 12.99, null },
                    { 21, "smartphones", "An apple mobile which is nothing like apple", "https://d57avc95tvxyg.cloudfront.net/images/thumbnails/400/400/detailed/2449/full_body_housing_for_apple_iphone_9_white_maxbhi.com_41205.jpg?t=1700812354", "iPhone 9", 549.0, null },
                    { 22, "smartphones", "SIM-Free, Model A19211 6.5-inch Super Retina HD display with OLED technology A12 Bionic chip with ...", "https://d57avc95tvxyg.cloudfront.net/images/thumbnails/761/761/detailed/2884/full_body_housing_for_apple_iphone_x_plus_gold_maxbhi_com_40666.jpg?t=1700821762", "iPhone X", 899.0, null },
                    { 23, "smartphones", "Samsung's new variant which goes beyond Galaxy to the Universe", "https://pbs.twimg.com/media/Dr2wz4AU4AEXQeN?format=jpg&name=900x900", "Samsung Universe 9", 1249.0, null },
                    { 24, "smartphones", "OPPO F19 is officially announced on April 2021.", "https://imei.org/storage/files/images/6343/preview/oppo-f19-1.png", "OPPOF19", 280.0, null },
                    { 25, "smartphones", "Huawei’s re-badged P30 Pro New Edition was officially unveiled yesterday in Germany and now the device has made its way to the UK.", "https://m.media-amazon.com/images/I/61TsiAtMVQL._AC_SL1000_.jpg", "Huawei P30", 499.0, null },
                    { 26, "laptops", "MacBook Pro 2021 with mini-LED display may launch between September, November", "https://m.media-amazon.com/images/I/615mtxVd8+L._AC_SL1500_.jpg", "MacBook Pro", 1749.0, null },
                    { 27, "laptops", "Samsung Galaxy Book S (2020) Laptop With Intel Lakefield Chip, 8GB of RAM Launched", "https://i5.walmartimages.com/seo/SAMSUNG-Galaxy-Book-Go-14-FHD-Laptop-4GB-Memory-64GB-HD-Silver-Windows-11_6b6b54f5-fa78-4278-a752-6e5166a7f161.3118788ed16fe26fbd733a82ae739e78.jpeg", "Samsung Galaxy Book", 1499.0, null },
                    { 28, "laptops", "Style and speed. Stand out on HD video calls backed by Studio Mics. Capture ideas on the vibrant touchscreen.", "https://i5.walmartimages.com/seo/SAMSUNG-Galaxy-Book-Go-14-FHD-Laptop-4GB-Memory-64GB-HD-Silver-Windows-11_6b6b54f5-fa78-4278-a752-6e5166a7f161.3118788ed16fe26fbd733a82ae739e78.jpeg", "Microsoft Surface Laptop 4", 1499.0, null },
                    { 29, "laptops", "Infinix Inbook X1 Ci3 10th 8GB 256GB 14 Win10 Grey – 1 Year Warranty", "https://m.media-amazon.com/images/I/71vnokFltKL._AC_SX679_.jpg", "Infinix INBOOK", 1099.0, null },
                    { 30, "laptops", "HP Pavilion 15-DK1056WM Gaming Laptop 10th Gen Core i5, 8GB, 256GB SSD, GTX 1650 4GB, Windows 10", "https://i5.walmartimages.com/seo/HP-Pavilion-15-6-FHD-Gaming-Laptop-Intel-Core-i5-10300H-8GB-RAM-NVIDIA-GeForce-GTX-1650-4GB-250GB-SSD-Windows-10-Home-Black-15-dk1056wm_8b269d16-6343-40c0-832f-e4d394ad8b75.9a1d5beb1ed0c4b7815d8657536428f9.jpeg", "HP Pavilion 15-DK1056WM", 1099.0, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.AlterColumn<string>(
                name: "SpecialTag",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
