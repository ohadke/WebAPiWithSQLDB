using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;

namespace TodoApi.Configurations
{
    public class ToDoConfiguration : IEntityTypeConfiguration<TodoItem>
    {
        public void Configure(EntityTypeBuilder<TodoItem> builder)
        {
            builder.ToTable("Todos");//Name of the table
            builder.HasKey(t => t.Id);//Choose the Primary Key
            builder.Property(t => t.IsComplete).IsRequired();//Add column to the table, cannot be empty when inserted
            builder.Property(t => t.Name).IsRequired();//Add column to the table, cannot be empty when inserted
            builder.Property(t => t.Secret);//Add column to the table, CAN be empty when inserted
        }
    }
}
