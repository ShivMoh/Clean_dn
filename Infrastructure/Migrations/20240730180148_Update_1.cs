using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Update_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alumni_Address_AddressId",
                table: "Alumni");

            migrationBuilder.DropForeignKey(
                name: "FK_Alumni_BiographicalInformation_BiographicalInformationId",
                table: "Alumni");

            migrationBuilder.DropForeignKey(
                name: "FK_Alumni_Contact_ContactId",
                table: "Alumni");

            migrationBuilder.DropForeignKey(
                name: "FK_Alumni_Gender_GenderId",
                table: "Alumni");

            migrationBuilder.DropForeignKey(
                name: "FK_Alumni_MaritalStatus_MaritalStatusId",
                table: "Alumni");

            migrationBuilder.DropForeignKey(
                name: "FK_Alumni_Occupation_OccupationId",
                table: "Alumni");

            migrationBuilder.DropForeignKey(
                name: "FK_Department_Faculty_FacultyId",
                table: "Department");

            migrationBuilder.DropForeignKey(
                name: "FK_Program_Department_DepartmentId",
                table: "Program");

            migrationBuilder.DropForeignKey(
                name: "FK_Program_ProgramCategory_ProgramCategoryId",
                table: "Program");

            migrationBuilder.DropForeignKey(
                name: "FK_Program_Usi_UsiId",
                table: "Program");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserCategory_UserCategoryId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Usi_Alumni_AlumniId",
                table: "Usi");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usi",
                table: "Usi");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserCategory",
                table: "UserCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProgramCategory",
                table: "ProgramCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Program",
                table: "Program");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Occupation",
                table: "Occupation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaritalStatus",
                table: "MaritalStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gender",
                table: "Gender");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Faculty",
                table: "Faculty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Department",
                table: "Department");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contact",
                table: "Contact");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Alumni",
                table: "Alumni");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.RenameTable(
                name: "Usi",
                newName: "Usis");

            migrationBuilder.RenameTable(
                name: "UserCategory",
                newName: "UserCategories");

            migrationBuilder.RenameTable(
                name: "ProgramCategory",
                newName: "ProgramCategories");

            migrationBuilder.RenameTable(
                name: "Program",
                newName: "Programs");

            migrationBuilder.RenameTable(
                name: "Occupation",
                newName: "Occupations");

            migrationBuilder.RenameTable(
                name: "MaritalStatus",
                newName: "MaritalStatuses");

            migrationBuilder.RenameTable(
                name: "Gender",
                newName: "Genders");

            migrationBuilder.RenameTable(
                name: "Faculty",
                newName: "Faculties");

            migrationBuilder.RenameTable(
                name: "Department",
                newName: "Departments");

            migrationBuilder.RenameTable(
                name: "Contact",
                newName: "Contacts");

            migrationBuilder.RenameTable(
                name: "Alumni",
                newName: "Alumnis");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "Addresses");

            migrationBuilder.RenameIndex(
                name: "IX_Usi_AlumniId",
                table: "Usis",
                newName: "IX_Usis_AlumniId");

            migrationBuilder.RenameIndex(
                name: "IX_Program_UsiId",
                table: "Programs",
                newName: "IX_Programs_UsiId");

            migrationBuilder.RenameIndex(
                name: "IX_Program_ProgramCategoryId",
                table: "Programs",
                newName: "IX_Programs_ProgramCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Program_DepartmentId",
                table: "Programs",
                newName: "IX_Programs_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Department_FacultyId",
                table: "Departments",
                newName: "IX_Departments_FacultyId");

            migrationBuilder.RenameIndex(
                name: "IX_Alumni_OccupationId",
                table: "Alumnis",
                newName: "IX_Alumnis_OccupationId");

            migrationBuilder.RenameIndex(
                name: "IX_Alumni_MaritalStatusId",
                table: "Alumnis",
                newName: "IX_Alumnis_MaritalStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Alumni_GenderId",
                table: "Alumnis",
                newName: "IX_Alumnis_GenderId");

            migrationBuilder.RenameIndex(
                name: "IX_Alumni_ContactId",
                table: "Alumnis",
                newName: "IX_Alumnis_ContactId");

            migrationBuilder.RenameIndex(
                name: "IX_Alumni_BiographicalInformationId",
                table: "Alumnis",
                newName: "IX_Alumnis_BiographicalInformationId");

            migrationBuilder.RenameIndex(
                name: "IX_Alumni_AddressId",
                table: "Alumnis",
                newName: "IX_Alumnis_AddressId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usis",
                table: "Usis",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserCategories",
                table: "UserCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProgramCategories",
                table: "ProgramCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Programs",
                table: "Programs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Occupations",
                table: "Occupations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaritalStatuses",
                table: "MaritalStatuses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genders",
                table: "Genders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Faculties",
                table: "Faculties",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Alumnis",
                table: "Alumnis",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Alumnis_Addresses_AddressId",
                table: "Alumnis",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Alumnis_BiographicalInformation_BiographicalInformationId",
                table: "Alumnis",
                column: "BiographicalInformationId",
                principalTable: "BiographicalInformation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Alumnis_Contacts_ContactId",
                table: "Alumnis",
                column: "ContactId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Alumnis_Genders_GenderId",
                table: "Alumnis",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Alumnis_MaritalStatuses_MaritalStatusId",
                table: "Alumnis",
                column: "MaritalStatusId",
                principalTable: "MaritalStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Alumnis_Occupations_OccupationId",
                table: "Alumnis",
                column: "OccupationId",
                principalTable: "Occupations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Faculties_FacultyId",
                table: "Departments",
                column: "FacultyId",
                principalTable: "Faculties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Programs_Departments_DepartmentId",
                table: "Programs",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Programs_ProgramCategories_ProgramCategoryId",
                table: "Programs",
                column: "ProgramCategoryId",
                principalTable: "ProgramCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Programs_Usis_UsiId",
                table: "Programs",
                column: "UsiId",
                principalTable: "Usis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserCategories_UserCategoryId",
                table: "Users",
                column: "UserCategoryId",
                principalTable: "UserCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usis_Alumnis_AlumniId",
                table: "Usis",
                column: "AlumniId",
                principalTable: "Alumnis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alumnis_Addresses_AddressId",
                table: "Alumnis");

            migrationBuilder.DropForeignKey(
                name: "FK_Alumnis_BiographicalInformation_BiographicalInformationId",
                table: "Alumnis");

            migrationBuilder.DropForeignKey(
                name: "FK_Alumnis_Contacts_ContactId",
                table: "Alumnis");

            migrationBuilder.DropForeignKey(
                name: "FK_Alumnis_Genders_GenderId",
                table: "Alumnis");

            migrationBuilder.DropForeignKey(
                name: "FK_Alumnis_MaritalStatuses_MaritalStatusId",
                table: "Alumnis");

            migrationBuilder.DropForeignKey(
                name: "FK_Alumnis_Occupations_OccupationId",
                table: "Alumnis");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Faculties_FacultyId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Programs_Departments_DepartmentId",
                table: "Programs");

            migrationBuilder.DropForeignKey(
                name: "FK_Programs_ProgramCategories_ProgramCategoryId",
                table: "Programs");

            migrationBuilder.DropForeignKey(
                name: "FK_Programs_Usis_UsiId",
                table: "Programs");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserCategories_UserCategoryId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Usis_Alumnis_AlumniId",
                table: "Usis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usis",
                table: "Usis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserCategories",
                table: "UserCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Programs",
                table: "Programs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProgramCategories",
                table: "ProgramCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Occupations",
                table: "Occupations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaritalStatuses",
                table: "MaritalStatuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genders",
                table: "Genders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Faculties",
                table: "Faculties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Alumnis",
                table: "Alumnis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.RenameTable(
                name: "Usis",
                newName: "Usi");

            migrationBuilder.RenameTable(
                name: "UserCategories",
                newName: "UserCategory");

            migrationBuilder.RenameTable(
                name: "Programs",
                newName: "Program");

            migrationBuilder.RenameTable(
                name: "ProgramCategories",
                newName: "ProgramCategory");

            migrationBuilder.RenameTable(
                name: "Occupations",
                newName: "Occupation");

            migrationBuilder.RenameTable(
                name: "MaritalStatuses",
                newName: "MaritalStatus");

            migrationBuilder.RenameTable(
                name: "Genders",
                newName: "Gender");

            migrationBuilder.RenameTable(
                name: "Faculties",
                newName: "Faculty");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "Department");

            migrationBuilder.RenameTable(
                name: "Contacts",
                newName: "Contact");

            migrationBuilder.RenameTable(
                name: "Alumnis",
                newName: "Alumni");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "Address");

            migrationBuilder.RenameIndex(
                name: "IX_Usis_AlumniId",
                table: "Usi",
                newName: "IX_Usi_AlumniId");

            migrationBuilder.RenameIndex(
                name: "IX_Programs_UsiId",
                table: "Program",
                newName: "IX_Program_UsiId");

            migrationBuilder.RenameIndex(
                name: "IX_Programs_ProgramCategoryId",
                table: "Program",
                newName: "IX_Program_ProgramCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Programs_DepartmentId",
                table: "Program",
                newName: "IX_Program_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Departments_FacultyId",
                table: "Department",
                newName: "IX_Department_FacultyId");

            migrationBuilder.RenameIndex(
                name: "IX_Alumnis_OccupationId",
                table: "Alumni",
                newName: "IX_Alumni_OccupationId");

            migrationBuilder.RenameIndex(
                name: "IX_Alumnis_MaritalStatusId",
                table: "Alumni",
                newName: "IX_Alumni_MaritalStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Alumnis_GenderId",
                table: "Alumni",
                newName: "IX_Alumni_GenderId");

            migrationBuilder.RenameIndex(
                name: "IX_Alumnis_ContactId",
                table: "Alumni",
                newName: "IX_Alumni_ContactId");

            migrationBuilder.RenameIndex(
                name: "IX_Alumnis_BiographicalInformationId",
                table: "Alumni",
                newName: "IX_Alumni_BiographicalInformationId");

            migrationBuilder.RenameIndex(
                name: "IX_Alumnis_AddressId",
                table: "Alumni",
                newName: "IX_Alumni_AddressId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usi",
                table: "Usi",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserCategory",
                table: "UserCategory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Program",
                table: "Program",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProgramCategory",
                table: "ProgramCategory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Occupation",
                table: "Occupation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaritalStatus",
                table: "MaritalStatus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gender",
                table: "Gender",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Faculty",
                table: "Faculty",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Department",
                table: "Department",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contact",
                table: "Contact",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Alumni",
                table: "Alumni",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Alumni_Address_AddressId",
                table: "Alumni",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Alumni_BiographicalInformation_BiographicalInformationId",
                table: "Alumni",
                column: "BiographicalInformationId",
                principalTable: "BiographicalInformation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Alumni_Contact_ContactId",
                table: "Alumni",
                column: "ContactId",
                principalTable: "Contact",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Alumni_Gender_GenderId",
                table: "Alumni",
                column: "GenderId",
                principalTable: "Gender",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Alumni_MaritalStatus_MaritalStatusId",
                table: "Alumni",
                column: "MaritalStatusId",
                principalTable: "MaritalStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Alumni_Occupation_OccupationId",
                table: "Alumni",
                column: "OccupationId",
                principalTable: "Occupation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Faculty_FacultyId",
                table: "Department",
                column: "FacultyId",
                principalTable: "Faculty",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Program_Department_DepartmentId",
                table: "Program",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Program_ProgramCategory_ProgramCategoryId",
                table: "Program",
                column: "ProgramCategoryId",
                principalTable: "ProgramCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Program_Usi_UsiId",
                table: "Program",
                column: "UsiId",
                principalTable: "Usi",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserCategory_UserCategoryId",
                table: "Users",
                column: "UserCategoryId",
                principalTable: "UserCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usi_Alumni_AlumniId",
                table: "Usi",
                column: "AlumniId",
                principalTable: "Alumni",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
