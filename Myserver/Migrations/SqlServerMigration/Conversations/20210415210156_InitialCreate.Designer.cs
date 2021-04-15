﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Myserver;

namespace Myserver.Migrations.SqlServerMigration.Conversations
{
    [DbContext(typeof(ConversationsDBContext))]
    [Migration("20210415210156_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Myserver.Models.Conversation", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("f_userid")
                        .HasColumnType("int");

                    b.Property<int?>("s_userid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("f_userid");

                    b.HasIndex("s_userid");

                    b.ToTable("Conversations");
                });

            modelBuilder.Entity("Myserver.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("usrName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Myserver.Models.Conversation", b =>
                {
                    b.HasOne("Myserver.Models.User", "f_user")
                        .WithMany()
                        .HasForeignKey("f_userid");

                    b.HasOne("Myserver.Models.User", "s_user")
                        .WithMany()
                        .HasForeignKey("s_userid");

                    b.Navigation("f_user");

                    b.Navigation("s_user");
                });
#pragma warning restore 612, 618
        }
    }
}
