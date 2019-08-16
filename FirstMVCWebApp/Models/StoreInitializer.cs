using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FirstMVCWebApp.Models
{
    public class StoreInitializer 
        : DropCreateDatabaseIfModelChanges<StoreContext>
    {

        protected override void Seed(StoreContext context)
        {
            context.Products.Add(new Product {
                Id=1,
                Name = "Бомбочка Для Ванны «Spice Boom»",
                Price = 90m,
                Description = "Способ применения: опустить бомбочку в ванну с теплой водой, дать раствориться. Принимать ванну с удовольствием и пользой!",
                Volume = 325,
                InStock = true,
                Src= "~/Img/bomb_spicyboom2.jpg"
            });

            context.Products.Add(new Product
            {
                Id = 2,
                Name = "Гель Для Душа «Forest Walk»",
                Price = 111m,
                Description = "Композиция эфирных масел розмарина и бергамота вмиг снимет усталость и вялость, повысит внимательность и улучшит настроение. ",
                Volume = 200,
                InStock = true,
                Src = "~/Img/bomb_spicyboom1.jpg"
            });

            context.Products.Add(new Product
            {
                Id = 3,
                Name = "Мыло С Нуля «Гранатовый Шелк»",
                Price = 69m,
                Description = "А еще у мыла «Гранатовый шелк» нежный кремовый аромат граната, который влюбляет в себя с первого вдоха!",
                Volume = 100,
                InStock = true,
                Src = "~/Img/nabor_serdce_big.jpg"
            });

            context.Products.Add(new Product
            {
                Id = 11,
                Name = "Мыло С Нуля «Гранатовый Шелк»",
                Price = 69m,
                Description = "А еще у мыла «Гранатовый шелк» нежный кремовый аромат граната, который влюбляет в себя с первого вдоха!",
                Volume = 100,
                InStock = true,
                Src = "~/Img/nabor_serdce_big2.jpg"
            });

            context.Products.Add(new Product
            {
                Id = 4,
                Name = "Мыло С Нуля «Гранатовый Шелк»",
                Price = 69m,
                Description = "А еще у мыла «Гранатовый шелк» нежный кремовый аромат граната, который влюбляет в себя с первого вдоха!",
                Volume = 100,
                InStock = true,
                Src = "~/Img/nabor_pink.jpg"
            });

            context.Products.Add(new Product
            {
                Id = 5,
                Name = "Мыло С Нуля «Гранатовый Шелк»",
                Price = 69m,
                Description = "А еще у мыла «Гранатовый шелк» нежный кремовый аромат граната, который влюбляет в себя с первого вдоха!",
                Volume = 100,
                InStock = true,
                Src = "~/Img/bomb_spicyboom2.jpg"
            });

            context.Products.Add(new Product
            {
                Id = 6,
                Name = "Мыло С Нуля «Гранатовый Шелк»",
                Price = 69m,
                Description = "А еще у мыла «Гранатовый шелк» нежный кремовый аромат граната, который влюбляет в себя с первого вдоха!",
                Volume = 100,
                InStock = true,
                Src = "~/Img/bomb_spicyboom2.jpg"
            });

            context.Products.Add(new Product
            {
                Id = 7,
                Name = "Мыло С Нуля «Гранатовый Шелк»",
                Price = 69m,
                Description = "А еще у мыла «Гранатовый шелк» нежный кремовый аромат граната, который влюбляет в себя с первого вдоха!",
                Volume = 100,
                InStock = true,
                Src = "Img//bomb_spicyboom2.jpg"
            });

            context.Products.Add(new Product
            {
                Id = 8,
                Name = "Мыло С Нуля «Гранатовый Шелк»",
                Price = 69m,
                Description = "А еще у мыла «Гранатовый шелк» нежный кремовый аромат граната, который влюбляет в себя с первого вдоха!",
                Volume = 100,
                InStock = true,
                Src = "~/Img/bomb_spicyboom2.jpg"
            });

            context.Products.Add(new Product
            {
                Id = 9,
                Name = "Мыло С Нуля «Гранатовый Шелк»",
                Price = 69m,
                Description = "А еще у мыла «Гранатовый шелк» нежный кремовый аромат граната, который влюбляет в себя с первого вдоха!",
                Volume = 100,
                InStock = true,
                Src = "~/Img/bomb_spicyboom2.jpg"
            });

            context.Products.Add(new Product
            {
                Id = 10,
                Name = "Мыло С Нуля «Гранатовый Шелк»",
                Price = 69m,
                Description = "А еще у мыла «Гранатовый шелк» нежный кремовый аромат граната, который влюбляет в себя с первого вдоха!",
                Volume = 100,
                InStock = true,
                Src = "~/Img/bomb_spicyboom2.jpg"
            });

            context.SaveChanges();

            base.Seed(context);
        }
    }
}