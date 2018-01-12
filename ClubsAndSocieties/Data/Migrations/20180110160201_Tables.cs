using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ClubsAndSocieties.Data.Migrations
{
    public partial class Tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Club_Administrator_AdministratorID",
                table: "Club");

            migrationBuilder.DropForeignKey(
                name: "FK_Event_Club_ClubID",
                table: "Event");

            migrationBuilder.DropForeignKey(
                name: "FK_Member_Club_ClubID",
                table: "Member");

            migrationBuilder.DropForeignKey(
                name: "FK_Member_Student_StudentID",
                table: "Member");

            migrationBuilder.DropForeignKey(
                name: "FK_Notification_Administrator_AdminID",
                table: "Notification");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_Event_EventID",
                table: "Post");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_Student_StudentID",
                table: "Post");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Post",
                table: "Post");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Notification",
                table: "Notification");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Member",
                table: "Member");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Event",
                table: "Event");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Club",
                table: "Club");

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "Students");

            migrationBuilder.RenameTable(
                name: "Post",
                newName: "Posts");

            migrationBuilder.RenameTable(
                name: "Notification",
                newName: "Notifications");

            migrationBuilder.RenameTable(
                name: "Member",
                newName: "Members");

            migrationBuilder.RenameTable(
                name: "Event",
                newName: "Events");

            migrationBuilder.RenameTable(
                name: "Club",
                newName: "Clubs");

            migrationBuilder.RenameIndex(
                name: "IX_Post_StudentID",
                table: "Posts",
                newName: "IX_Posts_StudentID");

            migrationBuilder.RenameIndex(
                name: "IX_Post_EventID",
                table: "Posts",
                newName: "IX_Posts_EventID");

            migrationBuilder.RenameIndex(
                name: "IX_Notification_AdminID",
                table: "Notifications",
                newName: "IX_Notifications_AdminID");

            migrationBuilder.RenameIndex(
                name: "IX_Member_StudentID",
                table: "Members",
                newName: "IX_Members_StudentID");

            migrationBuilder.RenameIndex(
                name: "IX_Member_ClubID",
                table: "Members",
                newName: "IX_Members_ClubID");

            migrationBuilder.RenameIndex(
                name: "IX_Event_ClubID",
                table: "Events",
                newName: "IX_Events_ClubID");

            migrationBuilder.RenameIndex(
                name: "IX_Club_AdministratorID",
                table: "Clubs",
                newName: "IX_Clubs_AdministratorID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Posts",
                table: "Posts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Notifications",
                table: "Notifications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Members",
                table: "Members",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Events",
                table: "Events",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clubs",
                table: "Clubs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Clubs_Administrator_AdministratorID",
                table: "Clubs",
                column: "AdministratorID",
                principalTable: "Administrator",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Clubs_ClubID",
                table: "Events",
                column: "ClubID",
                principalTable: "Clubs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Members_Clubs_ClubID",
                table: "Members",
                column: "ClubID",
                principalTable: "Clubs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Members_Students_StudentID",
                table: "Members",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_Administrator_AdminID",
                table: "Notifications",
                column: "AdminID",
                principalTable: "Administrator",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Events_EventID",
                table: "Posts",
                column: "EventID",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Students_StudentID",
                table: "Posts",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clubs_Administrator_AdministratorID",
                table: "Clubs");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Clubs_ClubID",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Members_Clubs_ClubID",
                table: "Members");

            migrationBuilder.DropForeignKey(
                name: "FK_Members_Students_StudentID",
                table: "Members");

            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_Administrator_AdminID",
                table: "Notifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Events_EventID",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Students_StudentID",
                table: "Posts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Posts",
                table: "Posts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Notifications",
                table: "Notifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Members",
                table: "Members");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Events",
                table: "Events");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clubs",
                table: "Clubs");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Student");

            migrationBuilder.RenameTable(
                name: "Posts",
                newName: "Post");

            migrationBuilder.RenameTable(
                name: "Notifications",
                newName: "Notification");

            migrationBuilder.RenameTable(
                name: "Members",
                newName: "Member");

            migrationBuilder.RenameTable(
                name: "Events",
                newName: "Event");

            migrationBuilder.RenameTable(
                name: "Clubs",
                newName: "Club");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_StudentID",
                table: "Post",
                newName: "IX_Post_StudentID");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_EventID",
                table: "Post",
                newName: "IX_Post_EventID");

            migrationBuilder.RenameIndex(
                name: "IX_Notifications_AdminID",
                table: "Notification",
                newName: "IX_Notification_AdminID");

            migrationBuilder.RenameIndex(
                name: "IX_Members_StudentID",
                table: "Member",
                newName: "IX_Member_StudentID");

            migrationBuilder.RenameIndex(
                name: "IX_Members_ClubID",
                table: "Member",
                newName: "IX_Member_ClubID");

            migrationBuilder.RenameIndex(
                name: "IX_Events_ClubID",
                table: "Event",
                newName: "IX_Event_ClubID");

            migrationBuilder.RenameIndex(
                name: "IX_Clubs_AdministratorID",
                table: "Club",
                newName: "IX_Club_AdministratorID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Post",
                table: "Post",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Notification",
                table: "Notification",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Member",
                table: "Member",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Event",
                table: "Event",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Club",
                table: "Club",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Club_Administrator_AdministratorID",
                table: "Club",
                column: "AdministratorID",
                principalTable: "Administrator",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Club_ClubID",
                table: "Event",
                column: "ClubID",
                principalTable: "Club",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Member_Club_ClubID",
                table: "Member",
                column: "ClubID",
                principalTable: "Club",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Member_Student_StudentID",
                table: "Member",
                column: "StudentID",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notification_Administrator_AdminID",
                table: "Notification",
                column: "AdminID",
                principalTable: "Administrator",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Event_EventID",
                table: "Post",
                column: "EventID",
                principalTable: "Event",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Student_StudentID",
                table: "Post",
                column: "StudentID",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
