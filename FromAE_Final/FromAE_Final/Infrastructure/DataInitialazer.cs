using FromAE_Final.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FromAE_Final.Infrastructure
{
    public class DataInitialazer
    {
        public static void Seed(IServiceScope scopedService)
        {
            using (var context = scopedService.ServiceProvider.GetRequiredService<FromAeDbContext>())
            {
                //if (!context.Menus.Any())
                //{
                //    context.Menus.AddRange(

                //        new Menu { Name = "ELEKTRONIKA", Link = "#" },
                //        new Menu { Name = "KOMPUTERLƏR", Link = "#" },
                //        new Menu { Name = "OYUNLAR", Link = "#" },
                //        new Menu { Name = "FOTO VƏ VİDEO", Link = "#" },
                //        new Menu { Name = "MƏİŞƏT AVADANLIQLARI", Link = "#" },
                //        new Menu { Name = "PARFÜM VƏ KOSMETİKA", Link = "#" },
                //        new Menu { Name = "EV ƏŞYALARI", Link = "#" },
                //        new Menu { Name = "MODA", Link = "#" }
                //        );
                //    context.SaveChanges();
                //}
                //if (!context.SubMenus.Any())
                //{
                //    context.SubMenus.AddRange(

                //        new SubMenu { Name = "Telefonlar", Link = "#",MenuId=1 },
                //        new SubMenu { Name = "Mobil aksesuarlar", Link = "#", MenuId = 1 },
                //        new SubMenu { Name = "TV və audio", Link = "#", MenuId = 1 },
                //        new SubMenu { Name = "Kompüter", Link = "#", MenuId = 2 },
                //        new SubMenu { Name = "Periferiya qurğuları", Link = "#", MenuId = 2 },
                //        new SubMenu { Name = "Kompüter Ehtiyyat hissələri", Link = "#", MenuId = 2 },
                //        new SubMenu { Name = "Tabletlər üçün üzlüklər", Link = "#", MenuId = 2 },
                //        new SubMenu { Name = "Şəbəkə Avadanlıqları", Link = "#", MenuId = 2 },
                //        new SubMenu { Name = "Oyun", Link = "#", MenuId = 3 },
                //        new SubMenu { Name = "Foto", Link = "#", MenuId = 4 },
                //        new SubMenu { Name = "Mətbəxt avadanlıqları", Link = "#", MenuId = 5 },  
                //        new SubMenu { Name = "Məişət avadanlıqları", Link = "#", MenuId = 5 },  
                //        new SubMenu { Name = "Gözəllik məhsulları", Link = "#", MenuId = 5 },  
                //        new SubMenu { Name = "Ətriyyat", Link = "#", MenuId = 6 },  
                //        new SubMenu { Name = "Beauty & Health", Link = "#", MenuId = 6 },  
                //        new SubMenu { Name = "Tekstil", Link = "#", MenuId = 7},
                //        new SubMenu { Name = "Koridor", Link = "#", MenuId = 7},
                //        new SubMenu { Name = "Hamam otağı", Link = "#", MenuId = 7},
                //        new SubMenu { Name = "Qab-qacaq", Link = "#", MenuId = 7},
                //        new SubMenu { Name = "Camaşırxana", Link = "#", MenuId = 7}


                //        );
                //    context.SaveChanges();
                //}

                var manager = scopedService.ServiceProvider.GetRequiredService<UserManager<AppUser>>();

                if (!manager.Users.Any())
                {
                    var config = scopedService.ServiceProvider.GetRequiredService<IConfiguration>();
                    AppUser appUser = new AppUser
                    {
                        UserName = config["User:username"],
                        Email = config["User:email"]
                    };
                    manager.CreateAsync(appUser, config["User:password"]).GetAwaiter().GetResult();

                    var rolemanager = scopedService.ServiceProvider.GetRequiredService<RoleManager<IdentityRole<int>>>();

                    List<IdentityRole<int>> roles = new List<IdentityRole<int>>();



                    if (!rolemanager.Roles.Any())
                    {
                        string[] rollar = config.GetSection("Role").Value.Split(",");
                        foreach (var item in rollar)
                        {
                            IdentityRole<int> identityRole = new IdentityRole<int>
                            {
                                Name = item
                            };
                            roles.Add(identityRole);
                            rolemanager.CreateAsync(identityRole).GetAwaiter().GetResult();
                        }
                    }
                    manager.AddToRoleAsync(appUser, roles[0].Name).GetAwaiter().GetResult();
                }
            }
        }
    }
}
