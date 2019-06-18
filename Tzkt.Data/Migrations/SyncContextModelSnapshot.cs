﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Tzkt.Data;

namespace Tzkt.Data.Migrations
{
    [DbContext(typeof(TzktContext))]
    partial class TzktContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Tzkt.Data.Models.ActivationOperation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<long>("Balance");

                    b.Property<int>("Level");

                    b.Property<string>("OpHash");

                    b.Property<DateTime>("Timestamp");

                    b.HasKey("Id");

                    b.ToTable("ActivationOps");
                });

            modelBuilder.Entity("Tzkt.Data.Models.AppState", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Hash");

                    b.Property<int>("Level");

                    b.Property<string>("Protocol");

                    b.Property<DateTime>("Timestamp");

                    b.HasKey("Id");

                    b.ToTable("AppState");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Hash = "",
                            Level = -1,
                            Protocol = "",
                            Timestamp = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Tzkt.Data.Models.BakerStat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("AccusationLostDeposit");

                    b.Property<long>("AccusationLostFee");

                    b.Property<long>("AccusationLostReward");

                    b.Property<long>("AccusationReward");

                    b.Property<int>("BakerId");

                    b.Property<long>("Balance");

                    b.Property<int>("Blocks");

                    b.Property<int>("BlocksExtra");

                    b.Property<int>("BlocksMissed");

                    b.Property<long>("BlocksReward");

                    b.Property<int>("Cycle");

                    b.Property<int>("Endorsements");

                    b.Property<int>("EndorsementsMissed");

                    b.Property<long>("EndorsementsReward");

                    b.Property<long>("FeesReward");

                    b.Property<long>("RevelationLostFee");

                    b.Property<long>("RevelationLostReward");

                    b.Property<long>("RevelationReward");

                    b.Property<long>("StakingBalance");

                    b.HasKey("Id");

                    b.HasIndex("BakerId");

                    b.ToTable("BakerStats");
                });

            modelBuilder.Entity("Tzkt.Data.Models.BakingRight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BakerId");

                    b.Property<int>("Level");

                    b.Property<int>("Priority");

                    b.HasKey("Id");

                    b.HasIndex("BakerId");

                    b.ToTable("BakingRights");
                });

            modelBuilder.Entity("Tzkt.Data.Models.BalanceSnapshot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("Balance");

                    b.Property<int>("ContractId");

                    b.Property<int>("DelegateId");

                    b.Property<int>("Level");

                    b.HasKey("Id");

                    b.HasIndex("ContractId");

                    b.HasIndex("DelegateId");

                    b.ToTable("BalanceSnapshots");
                });

            modelBuilder.Entity("Tzkt.Data.Models.Block", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BakerId");

                    b.Property<string>("Hash");

                    b.Property<int>("Level");

                    b.Property<int>("Priority");

                    b.Property<int>("ProtocolId");

                    b.Property<DateTime>("Timestamp");

                    b.Property<int>("Validations");

                    b.HasKey("Id");

                    b.HasIndex("BakerId");

                    b.HasIndex("ProtocolId");

                    b.ToTable("Blocks");
                });

            modelBuilder.Entity("Tzkt.Data.Models.Contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired()
                        .IsFixedLength(true)
                        .HasMaxLength(36);

                    b.Property<long>("Balance");

                    b.Property<long>("Counter");

                    b.Property<bool>("Delegatable");

                    b.Property<int?>("DelegateId");

                    b.Property<int>("DelegatorsCount");

                    b.Property<long>("Frozen");

                    b.Property<int>("Kind");

                    b.Property<int?>("ManagerId");

                    b.Property<string>("PublicKey")
                        .HasMaxLength(65);

                    b.Property<bool>("Spendable");

                    b.Property<bool>("Staked");

                    b.Property<long>("StakingBalance");

                    b.HasKey("Id");

                    b.HasIndex("Address")
                        .IsUnique();

                    b.HasIndex("DelegateId");

                    b.HasIndex("ManagerId");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("Tzkt.Data.Models.CycleStat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ActiveBakers");

                    b.Property<int>("ActiveDelegators");

                    b.Property<int>("CreatedContracts");

                    b.Property<int>("Cycle");

                    b.Property<int>("Snapshot");

                    b.Property<int>("TotalBalances");

                    b.Property<int>("TotalRolls");

                    b.Property<int>("Transactions");

                    b.Property<int>("TransactionsVolume");

                    b.HasKey("Id");

                    b.ToTable("CycleStats");
                });

            modelBuilder.Entity("Tzkt.Data.Models.DelegationOperation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Applied");

                    b.Property<int>("Counter");

                    b.Property<int?>("DelegateId");

                    b.Property<long>("Fee");

                    b.Property<bool>("Internal");

                    b.Property<int>("Level");

                    b.Property<string>("OpHash");

                    b.Property<int>("SenderId");

                    b.Property<DateTime>("Timestamp");

                    b.HasKey("Id");

                    b.HasIndex("DelegateId");

                    b.HasIndex("SenderId");

                    b.ToTable("DelegationOps");
                });

            modelBuilder.Entity("Tzkt.Data.Models.DelegatorStat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BakerId");

                    b.Property<long>("Balance");

                    b.Property<int>("Cycle");

                    b.Property<int>("DelegatorId");

                    b.HasKey("Id");

                    b.HasIndex("BakerId");

                    b.HasIndex("DelegatorId");

                    b.ToTable("DelegatorStats");
                });

            modelBuilder.Entity("Tzkt.Data.Models.DoubleBakingOperation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccusedLevel");

                    b.Property<int>("AccuserId");

                    b.Property<int>("BakerId");

                    b.Property<long>("Burned");

                    b.Property<int>("Level");

                    b.Property<int>("OffenderId");

                    b.Property<string>("OpHash");

                    b.Property<long>("Reward");

                    b.Property<DateTime>("Timestamp");

                    b.HasKey("Id");

                    b.HasIndex("AccuserId");

                    b.HasIndex("BakerId");

                    b.HasIndex("OffenderId");

                    b.ToTable("DoubleBakingOps");
                });

            modelBuilder.Entity("Tzkt.Data.Models.DoubleEndorsingOperation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccusedLevel");

                    b.Property<int>("AccuserId");

                    b.Property<int>("BakerId");

                    b.Property<long>("Burned");

                    b.Property<int>("Level");

                    b.Property<int>("OffenderId");

                    b.Property<string>("OpHash");

                    b.Property<long>("Reward");

                    b.Property<DateTime>("Timestamp");

                    b.HasKey("Id");

                    b.HasIndex("AccuserId");

                    b.HasIndex("BakerId");

                    b.HasIndex("OffenderId");

                    b.ToTable("DoubleEndorsingOps");
                });

            modelBuilder.Entity("Tzkt.Data.Models.EndorsementOperation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DelegateId");

                    b.Property<int>("Level");

                    b.Property<string>("OpHash");

                    b.Property<long>("Reward");

                    b.Property<int>("SlotsCount");

                    b.Property<DateTime>("Timestamp");

                    b.HasKey("Id");

                    b.HasIndex("DelegateId");

                    b.ToTable("EndorsementOps");
                });

            modelBuilder.Entity("Tzkt.Data.Models.EndorsingRight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BakerId");

                    b.Property<int>("Level");

                    b.Property<int>("Slots");

                    b.HasKey("Id");

                    b.HasIndex("BakerId");

                    b.ToTable("EndorsingRights");
                });

            modelBuilder.Entity("Tzkt.Data.Models.NonceRevelationOperation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BakerId");

                    b.Property<int>("Level");

                    b.Property<int>("NonceLevel");

                    b.Property<string>("OpHash");

                    b.Property<DateTime>("Timestamp");

                    b.HasKey("Id");

                    b.HasIndex("BakerId");

                    b.ToTable("NonceRevelationOps");
                });

            modelBuilder.Entity("Tzkt.Data.Models.OriginationOperation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Applied");

                    b.Property<long>("Balance");

                    b.Property<int>("ContractId");

                    b.Property<int>("Counter");

                    b.Property<bool>("Delegatable");

                    b.Property<int?>("DelegateId");

                    b.Property<long>("Fee");

                    b.Property<bool>("Internal");

                    b.Property<int>("Level");

                    b.Property<int>("ManagerId");

                    b.Property<string>("OpHash");

                    b.Property<int>("SenderId");

                    b.Property<bool>("Spendable");

                    b.Property<long>("StorageFee");

                    b.Property<DateTime>("Timestamp");

                    b.HasKey("Id");

                    b.HasIndex("ContractId");

                    b.HasIndex("DelegateId");

                    b.HasIndex("ManagerId");

                    b.HasIndex("SenderId");

                    b.ToTable("OriginationOps");
                });

            modelBuilder.Entity("Tzkt.Data.Models.Proposal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Hash");

                    b.HasKey("Id");

                    b.ToTable("Proposals");
                });

            modelBuilder.Entity("Tzkt.Data.Models.ProposalOperation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<int>("Level");

                    b.Property<string>("OpHash");

                    b.Property<int>("Period");

                    b.Property<int>("ProposalId");

                    b.Property<int>("SenderId");

                    b.Property<DateTime>("Timestamp");

                    b.HasKey("Id");

                    b.HasIndex("ProposalId");

                    b.HasIndex("SenderId");

                    b.ToTable("ProposalOps");

                    b.HasDiscriminator<string>("Discriminator").HasValue("ProposalOperation");
                });

            modelBuilder.Entity("Tzkt.Data.Models.Protocol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Blocks");

                    b.Property<string>("Hash");

                    b.HasKey("Id");

                    b.ToTable("Protocols");
                });

            modelBuilder.Entity("Tzkt.Data.Models.RevealOperation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Applied");

                    b.Property<int>("Counter");

                    b.Property<long>("Fee");

                    b.Property<bool>("Internal");

                    b.Property<int>("Level");

                    b.Property<string>("OpHash");

                    b.Property<string>("PublicKey");

                    b.Property<int>("SenderId");

                    b.Property<DateTime>("Timestamp");

                    b.HasKey("Id");

                    b.HasIndex("SenderId");

                    b.ToTable("RevealOps");
                });

            modelBuilder.Entity("Tzkt.Data.Models.TransactionOperation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("Amount");

                    b.Property<bool>("Applied");

                    b.Property<int>("Counter");

                    b.Property<long>("Fee");

                    b.Property<bool>("Internal");

                    b.Property<int>("Level");

                    b.Property<string>("OpHash");

                    b.Property<int>("SenderId");

                    b.Property<long>("StorageFee");

                    b.Property<bool>("TargetAllocated");

                    b.Property<int>("TargetId");

                    b.Property<DateTime>("Timestamp");

                    b.HasKey("Id");

                    b.HasIndex("SenderId");

                    b.HasIndex("TargetId");

                    b.ToTable("TransactionOps");
                });

            modelBuilder.Entity("Tzkt.Data.Models.BallotOperation", b =>
                {
                    b.HasBaseType("Tzkt.Data.Models.ProposalOperation");

                    b.Property<int>("Vote");

                    b.HasDiscriminator().HasValue("BallotOperation");
                });

            modelBuilder.Entity("Tzkt.Data.Models.BakerStat", b =>
                {
                    b.HasOne("Tzkt.Data.Models.Contract", "Baker")
                        .WithMany()
                        .HasForeignKey("BakerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Tzkt.Data.Models.BakingRight", b =>
                {
                    b.HasOne("Tzkt.Data.Models.Contract", "Baker")
                        .WithMany()
                        .HasForeignKey("BakerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Tzkt.Data.Models.BalanceSnapshot", b =>
                {
                    b.HasOne("Tzkt.Data.Models.Contract", "Contract")
                        .WithMany()
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Tzkt.Data.Models.Contract", "Delegate")
                        .WithMany()
                        .HasForeignKey("DelegateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Tzkt.Data.Models.Block", b =>
                {
                    b.HasOne("Tzkt.Data.Models.Contract", "Baker")
                        .WithMany()
                        .HasForeignKey("BakerId");

                    b.HasOne("Tzkt.Data.Models.Protocol", "Protocol")
                        .WithMany()
                        .HasForeignKey("ProtocolId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Tzkt.Data.Models.Contract", b =>
                {
                    b.HasOne("Tzkt.Data.Models.Contract", "Delegate")
                        .WithMany("DelegatedContracts")
                        .HasForeignKey("DelegateId");

                    b.HasOne("Tzkt.Data.Models.Contract", "Manager")
                        .WithMany("OriginatedContracts")
                        .HasForeignKey("ManagerId");
                });

            modelBuilder.Entity("Tzkt.Data.Models.DelegationOperation", b =>
                {
                    b.HasOne("Tzkt.Data.Models.Contract", "Delegate")
                        .WithMany()
                        .HasForeignKey("DelegateId");

                    b.HasOne("Tzkt.Data.Models.Contract", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Tzkt.Data.Models.DelegatorStat", b =>
                {
                    b.HasOne("Tzkt.Data.Models.Contract", "Baker")
                        .WithMany()
                        .HasForeignKey("BakerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Tzkt.Data.Models.Contract", "Delegator")
                        .WithMany()
                        .HasForeignKey("DelegatorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Tzkt.Data.Models.DoubleBakingOperation", b =>
                {
                    b.HasOne("Tzkt.Data.Models.Contract", "Accuser")
                        .WithMany()
                        .HasForeignKey("AccuserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Tzkt.Data.Models.Contract", "Baker")
                        .WithMany()
                        .HasForeignKey("BakerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Tzkt.Data.Models.Contract", "Offender")
                        .WithMany()
                        .HasForeignKey("OffenderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Tzkt.Data.Models.DoubleEndorsingOperation", b =>
                {
                    b.HasOne("Tzkt.Data.Models.Contract", "Accuser")
                        .WithMany()
                        .HasForeignKey("AccuserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Tzkt.Data.Models.Contract", "Baker")
                        .WithMany()
                        .HasForeignKey("BakerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Tzkt.Data.Models.Contract", "Offender")
                        .WithMany()
                        .HasForeignKey("OffenderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Tzkt.Data.Models.EndorsementOperation", b =>
                {
                    b.HasOne("Tzkt.Data.Models.Contract", "Delegate")
                        .WithMany()
                        .HasForeignKey("DelegateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Tzkt.Data.Models.EndorsingRight", b =>
                {
                    b.HasOne("Tzkt.Data.Models.Contract", "Baker")
                        .WithMany()
                        .HasForeignKey("BakerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Tzkt.Data.Models.NonceRevelationOperation", b =>
                {
                    b.HasOne("Tzkt.Data.Models.Contract", "Baker")
                        .WithMany()
                        .HasForeignKey("BakerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Tzkt.Data.Models.OriginationOperation", b =>
                {
                    b.HasOne("Tzkt.Data.Models.Contract", "Contract")
                        .WithMany()
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Tzkt.Data.Models.Contract", "Delegate")
                        .WithMany()
                        .HasForeignKey("DelegateId");

                    b.HasOne("Tzkt.Data.Models.Contract", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Tzkt.Data.Models.Contract", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Tzkt.Data.Models.ProposalOperation", b =>
                {
                    b.HasOne("Tzkt.Data.Models.Proposal", "Proposal")
                        .WithMany()
                        .HasForeignKey("ProposalId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Tzkt.Data.Models.Contract", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Tzkt.Data.Models.RevealOperation", b =>
                {
                    b.HasOne("Tzkt.Data.Models.Contract", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Tzkt.Data.Models.TransactionOperation", b =>
                {
                    b.HasOne("Tzkt.Data.Models.Contract", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Tzkt.Data.Models.Contract", "Target")
                        .WithMany()
                        .HasForeignKey("TargetId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
