﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace StaycationDemo.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Suites_Categories_CategoryId",
                table: "Suites");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Suites",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Houses with beauty backyard", "Enjoy the most comfortable backyard" },
                    { 2, "Hotels with large living room", "Large excusit living room" },
                    { 3, "Apartments with kitchen set", "Amazing beautiful kitchen for you." }
                });

            migrationBuilder.InsertData(
                table: "Suites",
                columns: new[] { "HotelId", "CategoryId", "ImageUrl", "IsBooked", "IsMostPicked", "Location", "LongDescription", "Name", "Price", "ShortDescription", "UserId" },
                values: new object[,]
                {
                    { 1, 0, "https://s3-alpha-sig.figma.com/img/a555/45e8/4b41bbf9f3857323fcb4bc9ec6d73b28?Expires=1675036800&Signature=J2FhbGH1l7ni-dEMAVnFOKzxp83SYB-5pVSCrrGTt-r7d7k57S0JydxtzG0ZTkUTA9zJCS4Fcqj-IU9-m~ZhlKaYnDf1DXafPUG16lkBSHpvxChkg7Iyr8L8j75VgdDThklUf~Wryr6sfAcvXnTBVgQDwlIqQjzHXtavD4wnt3C7wnVXlmwy9Nmc-HNCYHf3mBb1K~0rhDUwFPtj3D0WmbzUO0-Jn7h9zERyQu6aFwBzsAZGoZfgMkJ1SUi6jJOLTv7y565DUt3iXqc3AJnAt2SXKR8arFyWy08hFdfF6t~ww3qYguWgOqSKZh0eAvc9tqKVCg8Qbx~txIXAOchITg__&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4", false, true, "Jakarta, Indonesia", "A good hotel suite can ruin you for life. Why go back to your tiny apartment when you can live in style with butler service and views of an exotic foreign city? But there are some hotel suites that stand above the rest, whether it’s because of the indulgent amenities or the uniqueness of the location.", "Blue Origin Fams", 40000.95m, "Lorem Ipsum", null },
                    { 2, 0, "https://s3-alpha-sig.figma.com/img/8955/ded5/3081c0f429254adb0cda8fb59ce40f37?Expires=1675036800&Signature=U~E1XQsIjn5pXrPEAbMfOON6oqz2yP1Y7RL7BiCMDmDqQ3wNZUnQ4f3yF8IrZIWmlAdqzGaFZM~yDNGu7NrH0Rfq6Izz8IZmFXM1UytvnsyS81VrlWYQrX~6Y8W3CkA9tw9ZAo-LYq3t8q-34Sjafc-TGVxJIvD5wjmubglhFhYnMEdvvYDwWDMVmKRtazx48axvjWIi5Nq2u3Vqrt1Mq1hmikhkkRRFZ4P2FYX5zN2ak656iueascTaMEzc8qFDsi-3FS4Fszfkfl6b4w7GzPnegpNm5cIhKXy~HCqcOnLngH29QAZqcqyeNCAbRkJQLc-GuoVN5GVSZv3TnXGefw__&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4", false, true, "Bandung, Indonesia", "A good hotel suite can ruin you for life. Why go back to your tiny apartment when you can live in style with butler service and views of an exotic foreign city? But there are some hotel suites that stand above the rest, whether it’s because of the indulgent amenities or the uniqueness of the location.", "Ocean Land", 80000.95m, "Lorem Ipsum", null },
                    { 3, 0, "https://s3-alpha-sig.figma.com/img/b3aa/5c45/8dc6a9a4688c97f1c8be887fb02f7fc2?Expires=1675036800&Signature=JfQZMVprXzz1dbgu4G5wGgowSHLwZVdFiLE-k70HHPfpe2rBhijbp60lO893svqWdEywLpylP6hkoaDsKNjphIMWNGIz~Xf052tN0QPhChXojii75WBsR9-SlZGA7v-ysXSOhHPQFKw~41rAUnjMDuvCB9HlNTp8IZdYvNyqVCdt8hZIIW-wVQ4N9wvgeAJ5DZvpRN8XloF4pL-eM~scfqrl13nTN3DoMYnuydD078IwPsNS3~ktaVIKR-cQXpgnDxcILxYnotgOxq~Krq6bXaoWiYqhJELFhoqY33cgmsvqs5SEzqrSY-vbi84rGeq5rDG-SGgSBg4agff6axBJFw__&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4", false, true, "Malang, Indonesia", "A good hotel suite can ruin you for life. Why go back to your tiny apartment when you can live in style with butler service and views of an exotic foreign city? But there are some hotel suites that stand above the rest, whether it’s because of the indulgent amenities or the uniqueness of the location.", "Vinna Villa", 80000.95m, "Lorem Ipsum", null },
                    { 4, 0, "https://s3-alpha-sig.figma.com/img/44b6/9dd6/f12019d80399b9e7dbbbac5141dd2dd6?Expires=1675036800&Signature=I7NBE2w~DsX39BSWRIaFy63eBl3SoV5rEc368ewMf~TNFLWGfGO~Yw8brEZNTwIgZFx7ugsh~Ni9rtwPeztNHMB7pV3AhU135R36GpfdBsyhU8f263FGrFcAapzye28X8pQkxwuzIovjnJ9gzp9NRV3osViCa8gsdQ3HmR8lGYbpmoUq9Wzf1kaRWiEpPqp20vnzA6tenxS-qs7YdhyvKJ9AjSirFOPVDircpxvnB0j7fzUutsiE30IWHnhpWRNj15uUIGRXqBxITZ9l79wDBkEAuBPz4iP4at-VAHGpQu0lIdPu4jNRidqmtBygtV9ozBgZfOGeNogcZCfrVAl-SA__&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4", false, true, "Malang, Indonesia", "A good hotel suite can ruin you for life. Why go back to your tiny apartment when you can live in style with butler service and views of an exotic foreign city? But there are some hotel suites that stand above the rest, whether it’s because of the indulgent amenities or the uniqueness of the location.", "Stark House", 95000.95m, "Lorem Ipsum", null },
                    { 5, 0, "https://s3-alpha-sig.figma.com/img/993a/5af5/1da2cdcde737d5f9cb86317c35c23996?Expires=1675036800&Signature=i5opQip6DnYP2ZnEZOGAfkZTo42VOFYuBAOHZ~k9tz1J02WjcpbMf20-Dva6X4d6S9eeZmb3XKDBONn0X4PQhOSblCTduvW5vJquWri-ByLn0sOnb5iLr3baPd2GPc1aHFSUGEVQYl~FrGqo~6Xcj6gy2JkhDe7skZDxlV0dKc-keDAQx4Rv5AmMuNIgHKSdEERJKlyH58H0vakJ3aGJXpWGdeS8X7wwl8Bmm4J8olKwrsOBDLdSd77s1yVVosqrBJ4LYFHaefakKmCA5c0N0Xlx7mZnrrzvbQ8gT98QSWN6ttkH2gMgo79aERgxij6gmAsEiUXeaUnZMzVJt33Ong__&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4", false, true, "Medan, Indonesia", "A good hotel suite can ruin you for life. Why go back to your tiny apartment when you can live in style with butler service and views of an exotic foreign city? But there are some hotel suites that stand above the rest, whether it’s because of the indulgent amenities or the uniqueness of the location.", "Bobox", 60000.95m, "Lorem Ipsum", null }
                });

            migrationBuilder.InsertData(
                table: "Suites",
                columns: new[] { "HotelId", "CategoryId", "ImageUrl", "IsBooked", "IsMostPicked", "Location", "LongDescription", "Name", "Price", "ShortDescription", "UserId" },
                values: new object[,]
                {
                    { 6, 1, "https://s3-alpha-sig.figma.com/img/d344/88af/1e658f42775981f988c24d8466aa55cd?Expires=1675036800&Signature=SerLvN4J0Yzzt2oL3p5rGThxqiTjfQwqRDAFrlRGmHicM3v-WXGWzQaKz~UUW0icXsgSXc749vXLB~iKH7i8zLJawyAnuq~uE4YsrFDpdJ9HPxyxyJHo1g4jQB75oS-wKPLEIZGDxfEbG8ObyckQ0gVe74qChx6iBfN6AmudTnX-~tO7EGowh9z5m3olnxDgLm6jvp4okBzTqiHUGi~0uvhQs2dExDgxXNddL5J3Cz9WeJqehCKgqQoCdnfZOQ62HSfLGw8Eb00NHO3Ue3nksRhqFrMUEbbdkEV3UU9A3~h0qn56u0RVbnMfJ0Vm6Bi6nnl7LsjoDcQ3kPU0iXl1PQ__&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4", false, false, "Gunung Batu, Indonesia", "A good hotel suite can ruin you for life. Why go back to your tiny apartment when you can live in style with butler service and views of an exotic foreign city? But there are some hotel suites that stand above the rest, whether it’s because of the indulgent amenities or the uniqueness of the location..", "Tabby Town", 50000.95m, "Lorem Ipsum", null },
                    { 7, 1, "https://s3-alpha-sig.figma.com/img/65bb/be17/7f04fc9e6708f5ef38e8d9fe4df98844?Expires=1675036800&Signature=oIxpnlkJW9rYgv9FCMzgIfr2jTFvHCPa85~mY~xj2jr~WZXfdQ8asDcs7x95k2YxHS69EP1BPuCteJDg0JOWjKvpIpaiitRqSO7PWTkMd4iGvMkR9B8aC6cazMuCS8uLwnncm0YLOydY479lU-xkbo7O26YVYi4a5xoA5ndkMoqt4Bd-rHCfbL~BtpZtcRQVefdmrkINYHtSN-MJdofXfl4dMJmR27flTW2-i2gaDdqwgPmyGEabN9qZPCmJ7vKbQnVI8w8yuJixkZGjZQ9MxTMfIpK-KRr8XoOfdD5nn9it306-ix-kmmeSvdIs~ivEs9PDOvqg0IUsv0Ip50GWRA__&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4", false, false, "Bogor, Indonesia", "A good hotel suite can ruin you for life. Why go back to your tiny apartment when you can live in style with butler service and views of an exotic foreign city? But there are some hotel suites that stand above the rest, whether it’s because of the indulgent amenities or the uniqueness of the location.", "Anggana", 65000.95m, "Lorem Ipsum", null },
                    { 8, 1, "https://s3-alpha-sig.figma.com/img/b3b0/285d/24ca5531514bdb74d16f6cc672c596ab?Expires=1675036800&Signature=I9dNwWlo2LPXGnPN7DGhu0foWQaiGqyh5F2am7GNdVoT6CdV~uZcZ0k119GvhNhj~3MiuJoAK-z-0Up4ldhdDCKSKN6WSW2-OsnZHtgKayvddKk1dPLct134Kt9R8rpdV4ZpyQKKqo5yxjze5-eDdVfTv2OBX9g4AP-s6kuM3b2AGsDRPxEX8N70GwYYR6gG7tuWMOdv20rLqHCV1mmW-GCa74uwN4LgNoCmivUAxAQF6Vb~pQOcsSU3OPYBkT0fjyRLVXuD7Srvokh8gy34OTJkJpeUURy7X2KumsFHh8GEmjncWKeX2AN7Tpd5Rzo4IuBDHZo~DSmyJMHFU7nCzQ__&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4", false, false, "Jakarta, Indonesia", "A good hotel suite can ruin you for life. Why go back to your tiny apartment when you can live in style with butler service and views of an exotic foreign city? But there are some hotel suites that stand above the rest, whether it’s because of the indulgent amenities or the uniqueness of the location.", "Seattle Rain", 70000.95m, "Lorem Ipsum", null },
                    { 9, 1, "https://s3-alpha-sig.figma.com/img/b6b2/47eb/0fbdb2d61b318592a8e4415aad9b8292?Expires=1675036800&Signature=kB2jpq4S6pskxYXU-upTZING57bDgitjG81PduXLLYC4rTZxZEnkyWxVrFri~J9ldn10~liOu6V6rY4hlEmELnbFXV2KJBroaWA2h8MD5S1uTfn9np7FEijUC8cqmCk9libgcMBxWUsrvBDkC82q8HXApQS5Hy0kKvo72Rhxb-ySp2F5G9WSW6snOInl8QfXmnpQ7tzGeEc8r3XUcpVE3CdwEgL4ikdO6BVwBHUets2wGXCzb9uklkLnMxej9-W3im1-4dfvaDLt1f3l2usi0ZKTVtKYMUABW-6M8otm-ffDEfuA1mf3xxnGJdkrV54ABdl667Xgxrg1TQaHSipj0w__&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4", false, false, "Wonosobo, Indonesia", "A good hotel suite can ruin you for life. Why go back to your tiny apartment when you can live in style with butler service and views of an exotic foreign city? But there are some hotel suites that stand above the rest, whether it’s because of the indulgent amenities or the uniqueness of the location.", "Wodden Pit", 55000.95m, "Lorem Ipsum", null },
                    { 14, 2, "https://s3-alpha-sig.figma.com/img/35ce/45f2/2e9a0bb98d868c162430f2e632d2f1b4?Expires=1675641600&Signature=A2QOO8W65Tvr5sRnTb5BzmZy9wgd-4fuRt945GdNMUXkjJayjXzAXSKULQa~gVtqKAyrrK~XSFoWuWdYvqavqtsxNlJE7WmyGjbg5BEUERdJJHlF0nfiYkhheWryoFwlhK8zGH9tctTL~xpL5kRAbMWd2ElsewhZgzMHnHwuOb7k7VWMV9fkLsiUUX0yAEZwDy1z0qkHxa2UQB6q0ExYMewpNXMiZblzDlyuv5a2IsbBcWTMG89bLJ7v~7glpsKCCtF1sMa7fsqEgkLAJ7IYJpUK4j7~OWq97V9dRDLbaYokFxbdVpfssElBgyQdRYWB4-ycHXktv9o81layZCix9A__&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4", false, false, "Tangerang, Indonesia", "A good hotel suite can ruin you for life. Why go back to your tiny apartment when you can live in style with butler service and views of an exotic foreign city? But there are some hotel suites that stand above the rest, whether it’s because of the indulgent amenities or the uniqueness of the location.", "Green Park", 70000.95m, "Lorem Ipsum", null },
                    { 15, 2, "https://s3-alpha-sig.figma.com/img/bd30/d832/2872e7054a54aac3fd00a38d5f5f0742?Expires=1675641600&Signature=aOeBnkSramzZVz8SUKDiRgGdD-5ZxFj6Qs6FqKvO-~35G76fVn3wEvpC2kPwJ5leuxtn9OA7x1R9LBdhzHhhZ67gx1Dcq9xiDMPBrSurzNUUdNqBSABArT64HPFr9088WI8rfQjaoQhHOCSMohEr7hZjre-NbiRZriJ4uhzcZgJoyKfMrMWMsnVSwDJdEiOrsBaZ1myWeKop-HEgJp75xoGZAsxp-vQKYCPVAHQKcYYwHDu57sJhZbDD58OZHrGcnk-WtgeZWfbOSMWQ1eyEfQOaqq8SS7KBPoIuj2DITWvKxiaj20GyiXibudx~mpsD6O6IywcXM~dkqS50NK18sA__&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4", false, false, "Madiun, Indonesia", "A good hotel suite can ruin you for life. Why go back to your tiny apartment when you can live in style with butler service and views of an exotic foreign city? But there are some hotel suites that stand above the rest, whether it’s because of the indulgent amenities or the uniqueness of the location..", "Podo Wae", 90000.95m, "Lorem Ipsum", null },
                    { 16, 2, "https://s3-alpha-sig.figma.com/img/94cd/2d2f/7b06cad61b48a1af81bb06e5361246aa?Expires=1675641600&Signature=WKa8VD6vqvIU4YZCsaqitLx2braVAoTHy4VFP0GrvLTIL2LxBQLfPErjFlI4GNfxE-4CZZewiZWA~V1ekGaELCWB26y9TNM4IPGeH9hygxFfg2EVjHXr57DbSbCG~E-G~ZhALw1W2UcZepf8FJ61ac8pOmt68IOmPpKW6j9UfT4c3MUcvSpxTm4R7VIKgz1GUSv0d6XQsV4FWTpAeNE79NJOZD8tWMgT0zPDQHOw4ZT-Tj10eRMnThDECCS4TNuV4X0-Q~zPPovxJsUt0t8gPMA7Was~bhPpWdHX1zFrPv5G7RilK5SqyEc3xdFB9Eh-brD~Z366wCHTF5JbSaVceA__&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4", false, false, "Bandung, Indonesia", " A good hotel suite can ruin you for life. Why go back to your tiny apartment when you can live in style with butler service and views of an exotic foreign city? But there are some hotel suites that stand above the rest, whether it’s because of the indulgent amenities or the uniqueness of the location.", "Silver Rain", 70000.95m, "Lorem Ipsum", null },
                    { 17, 2, "https://s3-alpha-sig.figma.com/img/21a0/9502/cec2678562e78e53df473d7fb9ec27ac?Expires=1675641600&Signature=AlncwyAeVfmxHOWdJoGG6E14dQFBdixHFSfO2EewWLAJVwL2loXueuH-37p7CcHffgXzqWQptknxc44xBzXB9jCENzwUUu-I3F~KBjlIW3WbHpMz5zdDc9B6u7xFZAVVjUAzVMQIverZoeWKHjxz1V6OpQXqtEZM-wl2T63-AG~FmCpC7sapsLPPCrrzgb9y7y1U~ZjDICOV9aq7pbiYVj--GeummPpoLquOU-yuTftHLUgd6EencGQTBMclir0ei5G~N~JYaJpcrDXw6-kgsHLcT6qYC2Jz~FuIzigfxE~lhwM3-vXKl8g1Lds~9L9lobCaW7P1LM9~DxWvTFC6hg__&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4", false, false, "Kemang, Indonesia", "A good hotel suite can ruin you for life. Why go back to your tiny apartment when you can live in style with butler service and views of an exotic foreign city? But there are some hotel suites that stand above the rest, whether it’s because of the indulgent amenities or the uniqueness of the location.", "Cashville", 85000.95m, "Lorem Ipsum", null },
                    { 10, 3, "https://s3-alpha-sig.figma.com/img/47c7/2cfd/ec9e34e9ab998db9b5c50d2d81462f10?Expires=1675036800&Signature=AOjphd4y42z9i80ef-Yuex9Xrmm3frXyz0RFr1RWhoJCBwQm8NLhb5GUWXq2LBw0dy5P4R0UthH~hCg5noGAjpToUvENfQB6Ld1Yu3zjZV2AXK9y3wH9x9eFlXQdoTCxQtzEQ5howQJJ~F7DBEKqnJBapJ3TWTwPl-D0~NHNttAzqq0c~pnKIIPgzIK1fgrwEwGjhHaITsX9l4lzICECW92lah~TCuRT8QS1Mr9anIn0YWFf3pPpyu3X7w3hXARnSJJgNOZnv-Wu4Y33QTM-kXwTXGXRw8vQ~-u7MgggaD2R8QgdFr8tYqtyodLKAa2iP1MNp4tAkOV3BMojxyErXQ__&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4", false, false, "Depok, Indonesia", "A good hotel suite can ruin you for life. Why go back to your tiny apartment when you can live in style with butler service and views of an exotic foreign city? But there are some hotel suites that stand above the rest, whether it’s because of the indulgent amenities or the uniqueness of the location..", "PS Wood", 70000.95m, "Lorem Ipsum", null },
                    { 11, 3, "https://s3-alpha-sig.figma.com/img/cfd9/1f43/a7246dd72a017a69872528b2ef34b89d?Expires=1675036800&Signature=PeNBehPEBH3PYrqXG5f0IocortFNcHGD4S0lGJVU3tV5zbwAxs8XNokCS~wK1yASQNDDocK4vtB3UPFsDXSeZe6N4S~U8vSzw420CeMIbD4o~qoghjVn77OElt0dcaSPjPdNNEDCM3rLZclemPACYH40wIckGInOfZHhtJE6EXYWkhG9ruhBP9gVg3kpbVwuc-OzJWs4QUGxDFJm-nEEPeYPSf4zay0ha0nexkTFM7yQvxrOrIDmfXaMu2RUpZmwGhG9ZWBqJHS1q-34e7cxn7E~BqmkyNu2U5nCFYtDAYoyxDj4GtR2bRuc1qGhA~HyrZReLxMg5d1Pd3s4SgHXnA__&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4", false, false, "Jakarta, Indonesia", " A good hotel suite can ruin you for life. Why go back to your tiny apartment when you can live in style with butler service and views of an exotic foreign city? But there are some hotel suites that stand above the rest, whether it’s because of the indulgent amenities or the uniqueness of the location.", "One Five", 95000.95m, "Lorem Ipsum", null },
                    { 12, 3, "https://s3-alpha-sig.figma.com/img/bc47/5778/8e7106ae6e63a01bb610116f7ba738fe?Expires=1675036800&Signature=AVJS7d3Rjrikmd-pky-FtHtVufx16Oou4tPeyz9bLf5n40umv1CZ8Qzd6zRLBQOT~uYujdQEc4LYMKIMjoFoai1b17uDX3s1n~ubzv9C4~xZWtNAt5OAJ3Xba8qaHRKbYADAD6T-0-LVk0h1kv5fx9MD2~GEuCp-UWJR0GfkDaneRfmRMC4Ak7dILB9ZYQHiKaqs5YofxBKGP5SLgxBcVNaqRLD-i13Sx9HwClWXWIS3RiIMBNRdv1oY2Gswrzw3eMFiRaDpKs98Z3~LZjW75dkpA6Pmyy0bS5GY2p0sCg9eig6QS0jJeESq~vmMzToVvrPkhEk7uex~8aJMrnYuHA__&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4", false, false, "Bogor, Indonesia", "A good hotel suite can ruin you for life. Why go back to your tiny apartment when you can live in style with butler service and views of an exotic foreign city? But there are some hotel suites that stand above the rest, whether it’s because of the indulgent amenities or the uniqueness of the location..", "Minimal", 80000.95m, "Lorem Ipsum", null },
                    { 13, 3, "https://s3-alpha-sig.figma.com/img/6c1a/8b7e/f292c80af720ebd9f3fed37046d58b2d?Expires=1675036800&Signature=LEdRehNNgKVy1vNcW0iNjarnUWwBxL0oX16iKFAk63V2yiFLn8fv8xMMtDh6Y8C5gruDJjbkqCISzrBSNwqtenO057YkwIesqowJ8D4S67RHK~wWJTJ9sFWk02ZzkOw0XuSyYAJ4bVJj0qwffe9IHy44nlOhK8jOR4ilE3gRSlQafZ7fXLJAPFJYLMAKZSLQnPnWCkvRU2YsDq1G9FDhfijt9KYtyToKNvuxp162f8024Z7Y2836E5AXJxmBI4220KZ~U00gfDuyEkOldbDU6adkIt~MdhDbo8low~XVr~yekNSpF4sG5i0R5j8bguNv9LSbNsfbT44EX0JDwjtuyg__&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4", false, false, "Wonosobo, Indonesia", "A good hotel suite can ruin you for life. Why go back to your tiny apartment when you can live in style with butler service and views of an exotic foreign city? But there are some hotel suites that stand above the rest, whether it’s because of the indulgent amenities or the uniqueness of the location.", "Stays Home", 90000.95m, "Lorem Ipsum", null }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Suites_Categories_CategoryId",
                table: "Suites",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Suites_Categories_CategoryId",
                table: "Suites");

            migrationBuilder.DeleteData(
                table: "Suites",
                keyColumn: "HotelId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Suites",
                keyColumn: "HotelId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Suites",
                keyColumn: "HotelId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Suites",
                keyColumn: "HotelId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Suites",
                keyColumn: "HotelId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Suites",
                keyColumn: "HotelId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Suites",
                keyColumn: "HotelId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Suites",
                keyColumn: "HotelId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Suites",
                keyColumn: "HotelId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Suites",
                keyColumn: "HotelId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Suites",
                keyColumn: "HotelId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Suites",
                keyColumn: "HotelId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Suites",
                keyColumn: "HotelId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Suites",
                keyColumn: "HotelId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Suites",
                keyColumn: "HotelId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Suites",
                keyColumn: "HotelId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Suites",
                keyColumn: "HotelId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Suites",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Suites_Categories_CategoryId",
                table: "Suites",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
