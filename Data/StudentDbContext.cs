using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TESTKUSUM.Auth;
using TESTKUSUM.Model;

namespace TESTKUSUM.Data
{
    public class StudentDbContext : IdentityDbContext<ApplicationUser>
    {
        public StudentDbContext(DbContextOptions options) : base(options)
        {
        }
      
        public DbSet<Student> Students { get; set; }
        //public DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            this.SeedUsers(builder);
            this.SeedUserRoles(builder);
            this.SeedRoles(builder);
            //this.SeedTeacherData(builder);
        }
        private void SeedUsers(ModelBuilder builder)
        {
            var user1 = new ApplicationUser()
            {
                Id = "2d9d8997-bcb8-4ec9-8047-9562e0f75d22",
                UserName = "William",
                Email = "William@gmail.com",
                NormalizedEmail = "WILLIAM@GMAIL.COM",
                PhoneNumber= "1234567890",
                LockoutEnabled= false,
                
               
            };
            var user2 = new ApplicationUser()
            {
                Id = "6cc9459d-281c-4d85-b73b-b79fc0256043",
                UserName = "Ram",
                Email = "Ram@gmail.com",
                NormalizedEmail = "RAM@GMAIL.COM",
                PhoneNumber = "1234567890",
                LockoutEnabled = false,

            };
            var user3 = new ApplicationUser()
            {
                Id = "a4dc1bd9-75c1-4a53-b616-42a9edfebba8",
                UserName = "Geta",
                Email = "Geta@gmail.com",
                NormalizedEmail = "GETA@GMAIL.COM",
                PhoneNumber = "1234567890",
                LockoutEnabled = false,

            };
            var user4 = new ApplicationUser()
            {
                Id = "65223917-a64f-49b6-81c1-f54c88de0b21",
                UserName = "Babita",
                Email = "Babita@gmail.com",
                NormalizedEmail = "BABITA@GMAIL.COM",
                PhoneNumber = "1234567890",
                LockoutEnabled = false,

            };
            var user5 = new ApplicationUser()
            {
                Id = "0b2b8ee3-ef48-41e9-9793-37f9364ba107",
                UserName = "Sham",
                Email = "Sham@gmail.com",
                NormalizedEmail = "SHAM@GMAIL.COM",
                PhoneNumber = "1234567890",
                LockoutEnabled = false,

            };
            var user6 = new ApplicationUser()
            {
                Id = "c6a28bf5-090d-4ba3-8bdf-b494301a0a6d",
                UserName = "Isaan",
                Email = "Isaan@gmail.com",
                NormalizedEmail = "ISAAN@GMAIL.COM",
                PhoneNumber = "1234567890",
                LockoutEnabled = false,

            };
            var user7 = new ApplicationUser()
            {
                Id = "ba3f2090-64de-48ee-9586-4aa2b02bfb68",
                UserName = "Krina",
                Email = "Krina@gmail.com",
                NormalizedEmail = "KRINA@GMAIL.COM",
                PhoneNumber = "1234567890",
                LockoutEnabled = false,

            };
            var user8 = new ApplicationUser()
            {
                Id = "11bef6cb-6c76-4e3b-a074-69dea565b837",
                UserName = "Kajal",
                Email = "Kajal@gmail.com",
                NormalizedEmail = "KAJAL@GMAIL.COM",
                PhoneNumber = "1234567890",
                LockoutEnabled = false,

            };
            var user9 = new ApplicationUser()
            {
                Id = "b47d935c-0689-4112-9305-ae319fef394d",
                UserName = "Niki",
                Email = "Niki@gmail.com",
                NormalizedEmail = "NIKI@GMAIL.COM",
                PhoneNumber = "1234567890",
                LockoutEnabled = false,

            };
            var user10 = new ApplicationUser()
            {
                Id = "dc98e0e3-f296-4f2a-aee3-45c0cc56dab2",
                UserName = "Kitu",
                Email = "Kitu@gmail.com",
                NormalizedEmail = "KITU@GMAIL.COM",
                PhoneNumber = "1234567890",
                LockoutEnabled = false,

            };
            PasswordHasher<ApplicationUser> passwordHasher = new PasswordHasher<ApplicationUser>();
            user1.PasswordHash = passwordHasher.HashPassword(user1, "William@123");
            user2.PasswordHash = passwordHasher.HashPassword(user2, "Ram@123");
            user3.PasswordHash = passwordHasher.HashPassword(user3, "Geta@123");
            user4.PasswordHash = passwordHasher.HashPassword(user4, "Babita@123");
            user5.PasswordHash = passwordHasher.HashPassword(user5, "Sham@123");
            user6.PasswordHash = passwordHasher.HashPassword(user6, "Isaan@123");
            user7.PasswordHash = passwordHasher.HashPassword(user7, "Krina@123");
            user8.PasswordHash = passwordHasher.HashPassword(user8, "Kajal@123");
            user9.PasswordHash = passwordHasher.HashPassword(user9, "Niki@123");
            user10.PasswordHash = passwordHasher.HashPassword(user10, "Kitu@123");

            builder.Entity<ApplicationUser>().HasData(user1);
            builder.Entity<ApplicationUser>().HasData(user2);
            builder.Entity<ApplicationUser>().HasData(user3);
            builder.Entity<ApplicationUser>().HasData(user4);
            builder.Entity<ApplicationUser>().HasData(user5);
            builder.Entity<ApplicationUser>().HasData(user6);
            builder.Entity<ApplicationUser>().HasData(user7);
            builder.Entity<ApplicationUser>().HasData(user8);
            builder.Entity<ApplicationUser>().HasData(user9);
            builder.Entity<ApplicationUser>().HasData(user10);
        }
        private void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
               new IdentityRole() { Id = "fab4fac1-c546-41de-aebc-a14da6895711", Name = "Teacher", ConcurrencyStamp = "1", NormalizedName = "Teacher" },
               new IdentityRole() { Id = "c7b013f0-5201-4317-abd8-c211f91b7330", Name = "Student", ConcurrencyStamp = "2", NormalizedName = "Student" }
               );
        }
        private void SeedUserRoles(ModelBuilder builder)
        {//1
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895711", UserId = "2d9d8997-bcb8-4ec9-8047-9562e0f75d22" }
                );
            //2
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895711", UserId = "6cc9459d-281c-4d85-b73b-b79fc0256043" }
                );
            //3
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895711", UserId = "a4dc1bd9-75c1-4a53-b616-42a9edfebba8" }
                );
            //4
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895711", UserId = "65223917-a64f-49b6-81c1-f54c88de0b21" }
                );
            //5
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895711", UserId = "0b2b8ee3-ef48-41e9-9793-37f9364ba107" }
                );
            //6
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895711", UserId = "c6a28bf5-090d-4ba3-8bdf-b494301a0a6d" }
                );
            //7
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895711", UserId = "ba3f2090-64de-48ee-9586-4aa2b02bfb68" }
                );
            //8
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895711", UserId = "11bef6cb-6c76-4e3b-a074-69dea565b837" }
                );
            //9
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895711", UserId = "b47d935c-0689-4112-9305-ae319fef394d" }
                );
            //10
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895711", UserId = "dc98e0e3-f296-4f2a-aee3-45c0cc56dab2" }
                );
        }

        //private void SeedTeacherData(ModelBuilder builder)
        //{
        //    builder.Entity<Teacher>().HasData(new Teacher { TeacherId = Guid.NewGuid(), TeacherName = "William", TeacherEmail = "William@gmail.com", TeacherPassword = "William@123" });
        //    builder.Entity<Teacher>().HasData(new Teacher { TeacherId = Guid.NewGuid(), TeacherName = "Ram", TeacherEmail = "Ram@gmail.com", TeacherPassword= "Ram@123" });
        //    builder.Entity<Teacher>().HasData(new Teacher { TeacherId = Guid.NewGuid(), TeacherName = "Geta", TeacherEmail = "Geta@gmail.com", TeacherPassword = "Geta@123" });
        //    builder.Entity<Teacher>().HasData(new Teacher { TeacherId = Guid.NewGuid(), TeacherName = "Babita", TeacherEmail = "Babita@gmail.com", TeacherPassword = "Babita@123" });
        //    builder.Entity<Teacher>().HasData(new Teacher { TeacherId = Guid.NewGuid(), TeacherName = "Sham", TeacherEmail = "Sham@gmail.com", TeacherPassword = "Sham@123" });
        //    builder.Entity<Teacher>().HasData(new Teacher { TeacherId = Guid.NewGuid(), TeacherName = "Isaan", TeacherEmail = "Isaan@gmail.com", TeacherPassword = "Isaan@123" });
        //    builder.Entity<Teacher>().HasData(new Teacher { TeacherId = Guid.NewGuid(), TeacherName = "Krina", TeacherEmail = "Krina@gmail.com", TeacherPassword = "Krina@123" });
        //    builder.Entity<Teacher>().HasData(new Teacher { TeacherId = Guid.NewGuid(), TeacherName = "Kajal", TeacherEmail = "Kajal@gmail.com" , TeacherPassword = "Kajal@123" });
        //    builder.Entity<Teacher>().HasData(new Teacher { TeacherId = Guid.NewGuid(), TeacherName = "Niki", TeacherEmail = "Niki@gmail.com", TeacherPassword = "Niki@123" });
        //    builder.Entity<Teacher>().HasData(new Teacher { TeacherId = Guid.NewGuid(), TeacherName = "Kitu", TeacherEmail = "Kitu@gmail.com", TeacherPassword = "Kitu@123" });
        //}

    }
}

