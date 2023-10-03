using Microsoft.EntityFrameworkCore;
using TestTask.Enums;
using TestTask.Models;

namespace TestTask.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Order> Orders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        //changed id from int to guid 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User[]
                {
                    new User { Id=new Guid("a2fcd44b-7df6-419c-99b9-bdb5aea75ad2"), Email="user1@gmail.com", Status=UserStatus.Active},
                    new User { Id=new Guid("509292e2-aa85-4977-9c91-60a849acf23b"), Email="user2@gmail.com", Status=UserStatus.Active},
                    new User { Id=new Guid("dca86a0f-b7fb-4e02-92a5-95fdae5c655c"), Email="user3@gmail.com", Status=UserStatus.Active},
                    new User { Id=new Guid("1fe9ba06-5604-4935-9f65-eaa9b7008bee"), Email="user4@gmail.com", Status=UserStatus.Active},
                    new User { Id=new Guid("06fc7431-b349-40e5-a164-731cae812f66"), Email="user5@gmail.com", Status=UserStatus.Inactive},
                    new User { Id=new Guid("5178b392-f04e-43c6-978f-97504131bf3f"), Email="user6@gmail.com", Status=UserStatus.Inactive},
                    new User { Id=new Guid("0034123f-b24f-4ff4-9eba-4bb716ccf55a"), Email="user7@gmail.com", Status=UserStatus.Active},
                });

            modelBuilder.Entity<Order>().HasData(
                new Order[]
                {
                    new Order {Id=new Guid("be4bca81-26eb-4f73-80d8-050a0f00e462"), ProductName="Apple", Price=10, Quantity=5, UserId=new Guid("a2fcd44b-7df6-419c-99b9-bdb5aea75ad2")},
                    new Order {Id=new Guid("97987e49-9b75-437c-9f74-a49568a6e5a2"), ProductName="Lemon", Price=30, Quantity=2, UserId=new Guid("a2fcd44b-7df6-419c-99b9-bdb5aea75ad2")},
                    new Order {Id=new Guid("7706c658-9fb7-4375-b3de-9c349e761437"), ProductName="Cucumber", Price=5, Quantity=10, UserId=new Guid("a2fcd44b-7df6-419c-99b9-bdb5aea75ad2")},
                    new Order {Id=new Guid("b5dffd13-6400-4fa5-aa89-b5d0274d7dd2"), ProductName="Cabbage", Price=7, Quantity=2, UserId=new Guid("509292e2-aa85-4977-9c91-60a849acf23b")},
                    new Order {Id=new Guid("1d346b54-ba28-411d-ae93-a851e583f418"), ProductName="Onion", Price=8, Quantity=6, UserId=new Guid("509292e2-aa85-4977-9c91-60a849acf23b")},
                    new Order {Id=new Guid("f473dea9-aefc-4a23-9ad3-a3d179b1151c"), ProductName="Carrot", Price=9, Quantity=5, UserId=new Guid("509292e2-aa85-4977-9c91-60a849acf23b")},
                    new Order {Id=new Guid("e4a8ebaa-6a9f-4410-a770-60bd5839415e"), ProductName="Mango", Price=40, Quantity=2, UserId=new Guid("dca86a0f-b7fb-4e02-92a5-95fdae5c655c")},
                    new Order {Id=new Guid("5950adf8-9e8c-4066-8550-7648608c3e90"), ProductName="Orange", Price=45, Quantity=5, UserId=new Guid("1fe9ba06-5604-4935-9f65-eaa9b7008bee")},
                    new Order {Id=new Guid("f8643ac7-c557-4ea6-8862-380693910545"), ProductName="Watermelon", Price=100, Quantity=1, UserId=new Guid("1fe9ba06-5604-4935-9f65-eaa9b7008bee")},
                    new Order {Id=new Guid("07b58f5d-bd6c-43f5-8041-a0aac4c2324b"), ProductName="Garlic", Price=8, Quantity=12, UserId=new Guid("1fe9ba06-5604-4935-9f65-eaa9b7008bee")},
                    new Order {Id=new Guid("73163c07-59af-490a-8733-9e8be6e8f4f6"), ProductName="Potato", Price=3, Quantity=100, UserId=new Guid("0034123f-b24f-4ff4-9eba-4bb716ccf55a")},
                    new Order {Id=new Guid("355a4e55-de3e-4141-9755-ebab3d3dda81"), ProductName="Carrot", Price=9, Quantity=15, UserId=new Guid("0034123f-b24f-4ff4-9eba-4bb716ccf55a")},
                    new Order {Id=new Guid("e40378ea-ee33-48c6-b41a-b1cc1c310a65"), ProductName="Onion", Price=8, Quantity=15, UserId=new Guid("0034123f-b24f-4ff4-9eba-4bb716ccf55a")},
                    new Order {Id=new Guid("f5a6d42e-6770-4b60-8335-6c73fa89bf52"), ProductName="Pumpkin", Price=50, Quantity=1, UserId=new Guid("0034123f-b24f-4ff4-9eba-4bb716ccf55a")},
                    new Order {Id=new Guid("db86c26d-4b8f-407c-9548-b4a165a7ef43"), ProductName="Watermelon", Price=100, Quantity=12, UserId=new Guid("0034123f-b24f-4ff4-9eba-4bb716ccf55a")},
                });
        }
    }
}
