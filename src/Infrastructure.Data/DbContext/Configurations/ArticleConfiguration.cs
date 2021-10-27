using Domain.Entities;
using Domain.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.DbContext.Configurations
{
    public class ArticleConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.Property(x => x.Title).IsRequired();
            builder.HasMany(x => x.FileUploads)
                .WithOne(x => x.Article)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
    public class FileUploadConfiguration : IEntityTypeConfiguration<FileUpload>
    {
        public void Configure(EntityTypeBuilder<FileUpload> builder)
        {
            builder.Property(x => x.ImagePath).IsRequired();
        }
    }
}
