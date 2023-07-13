using System;
using System.Collections.Generic;
using Cahtbot.Models;
using Chatbot.Models;
using Microsoft.EntityFrameworkCore;

namespace WebAPI;

public partial class ChatbotContext : DbContext
{
    public ChatbotContext()
    {
    }
    
    public ChatbotContext(DbContextOptions<ChatbotContext> options)
        : base(options)
    {
    }
    public virtual DbSet<Package> Packages { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=ISLAMWARASNAH\\SQLEXPRESS;Database=ChatBot;Encrypt=false;Trusted_Connection=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Package>(entity =>
        {
            entity.Property(e => e.DataDigest).HasColumnName("data_digest");
            entity.Property(e => e.FromCode).HasColumnName("from_code");
            entity.Property(e => e.LogisticsInterface).HasColumnName("logistics_interface");
            entity.Property(e => e.MsgId).HasColumnName("msg_id");
            entity.Property(e => e.MsgType).HasColumnName("msg_type");
            entity.Property(e => e.PartnerCode).HasColumnName("partner_code");
        });
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
