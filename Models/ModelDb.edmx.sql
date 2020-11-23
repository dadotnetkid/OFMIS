
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/22/2020 17:38:39
-- Generated from EDMX file: D:\Software Development\Repositories\OFMIS\Models\ModelDb.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [OFMIS];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Actions_Actions]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Actions] DROP CONSTRAINT [FK_Actions_Actions];
GO
IF OBJECT_ID(N'[dbo].[FK_AIRDetails_AIReports]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AIRDetails] DROP CONSTRAINT [FK_AIRDetails_AIReports];
GO
IF OBJECT_ID(N'[dbo].[FK_AIReports_PurchaseRequests]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AIReports] DROP CONSTRAINT [FK_AIReports_PurchaseRequests];
GO
IF OBJECT_ID(N'[dbo].[FK_AIReports_Users]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AIReports] DROP CONSTRAINT [FK_AIReports_Users];
GO
IF OBJECT_ID(N'[dbo].[FK_AllotmentLetter_Appropriations]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AllotmentLetter] DROP CONSTRAINT [FK_AllotmentLetter_Appropriations];
GO
IF OBJECT_ID(N'[dbo].[FK_AllotmentLetter_PurchaseRequests]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AllotmentLetter] DROP CONSTRAINT [FK_AllotmentLetter_PurchaseRequests];
GO
IF OBJECT_ID(N'[dbo].[FK_Allotments_Appropriations]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Allotments] DROP CONSTRAINT [FK_Allotments_Appropriations];
GO
IF OBJECT_ID(N'[dbo].[FK_AOQ_Offices]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AOQ] DROP CONSTRAINT [FK_AOQ_Offices];
GO
IF OBJECT_ID(N'[dbo].[FK_AOQ_PurchaseRequests]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AOQ] DROP CONSTRAINT [FK_AOQ_PurchaseRequests];
GO
IF OBJECT_ID(N'[dbo].[FK_AOQ_Signatories]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AOQ] DROP CONSTRAINT [FK_AOQ_Signatories];
GO
IF OBJECT_ID(N'[dbo].[FK_AOQDetails_AOQ]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AOQDetails] DROP CONSTRAINT [FK_AOQDetails_AOQ];
GO
IF OBJECT_ID(N'[dbo].[FK_Appropriations_FundTypes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Appropriations] DROP CONSTRAINT [FK_Appropriations_FundTypes];
GO
IF OBJECT_ID(N'[dbo].[FK_APRDetails_APRs]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[APRDetails] DROP CONSTRAINT [FK_APRDetails_APRs];
GO
IF OBJECT_ID(N'[dbo].[FK_APRs_PurchaseRequests]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[APRs] DROP CONSTRAINT [FK_APRs_PurchaseRequests];
GO
IF OBJECT_ID(N'[dbo].[FK_BACInAOQ_AOQ]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BACInAOQ] DROP CONSTRAINT [FK_BACInAOQ_AOQ];
GO
IF OBJECT_ID(N'[dbo].[FK_BACInAOQ_Signatories]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BACInAOQ] DROP CONSTRAINT [FK_BACInAOQ_Signatories];
GO
IF OBJECT_ID(N'[dbo].[FK_BACMembers_Employees]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BACMembers] DROP CONSTRAINT [FK_BACMembers_Employees];
GO
IF OBJECT_ID(N'[dbo].[FK_BACMembers_Offices]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BACMembers] DROP CONSTRAINT [FK_BACMembers_Offices];
GO
IF OBJECT_ID(N'[dbo].[FK_ControlNumbers_Offices]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ControlNumbers] DROP CONSTRAINT [FK_ControlNumbers_Offices];
GO
IF OBJECT_ID(N'[dbo].[FK_DefaultAccounts_FundTypes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DefaultAccounts] DROP CONSTRAINT [FK_DefaultAccounts_FundTypes];
GO
IF OBJECT_ID(N'[dbo].[FK_DocumentActions_DocumentActions1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DocumentActions] DROP CONSTRAINT [FK_DocumentActions_DocumentActions1];
GO
IF OBJECT_ID(N'[dbo].[FK_DocumentActions_Offices]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DocumentActions] DROP CONSTRAINT [FK_DocumentActions_Offices];
GO
IF OBJECT_ID(N'[dbo].[FK_DocumentActions_Users]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DocumentActions] DROP CONSTRAINT [FK_DocumentActions_Users];
GO
IF OBJECT_ID(N'[dbo].[FK_Employees_Offices]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employees] DROP CONSTRAINT [FK_Employees_Offices];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeesInPayee_Employees]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmployeesInPayee] DROP CONSTRAINT [FK_EmployeesInPayee_Employees];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeesInPayee_Payees]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmployeesInPayee] DROP CONSTRAINT [FK_EmployeesInPayee_Payees];
GO
IF OBJECT_ID(N'[dbo].[FK_Files_Users]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Files] DROP CONSTRAINT [FK_Files_Users];
GO
IF OBJECT_ID(N'[dbo].[FK_ICS_PurchaseRequests]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ICS] DROP CONSTRAINT [FK_ICS_PurchaseRequests];
GO
IF OBJECT_ID(N'[dbo].[FK_ICSDetails_ICS]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ICSDetails] DROP CONSTRAINT [FK_ICSDetails_ICS];
GO
IF OBJECT_ID(N'[dbo].[FK_ItenaryDetails_ItenaryofTravels]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItenaryDetails] DROP CONSTRAINT [FK_ItenaryDetails_ItenaryofTravels];
GO
IF OBJECT_ID(N'[dbo].[FK_ItenaryofTravels_ApprovedBy]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItenaryofTravels] DROP CONSTRAINT [FK_ItenaryofTravels_ApprovedBy];
GO
IF OBJECT_ID(N'[dbo].[FK_ItenaryofTravels_Employees]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItenaryofTravels] DROP CONSTRAINT [FK_ItenaryofTravels_Employees];
GO
IF OBJECT_ID(N'[dbo].[FK_ItenaryofTravels_Obligations]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItenaryofTravels] DROP CONSTRAINT [FK_ItenaryofTravels_Obligations];
GO
IF OBJECT_ID(N'[dbo].[FK_Letters_Offices]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Letters] DROP CONSTRAINT [FK_Letters_Offices];
GO
IF OBJECT_ID(N'[dbo].[FK_Letters_Users]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Letters] DROP CONSTRAINT [FK_Letters_Users];
GO
IF OBJECT_ID(N'[dbo].[FK_Liquidations_Accountant]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Liquidations] DROP CONSTRAINT [FK_Liquidations_Accountant];
GO
IF OBJECT_ID(N'[dbo].[FK_Liquidations_Employees]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Liquidations] DROP CONSTRAINT [FK_Liquidations_Employees];
GO
IF OBJECT_ID(N'[dbo].[FK_Liquidations_Head]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Liquidations] DROP CONSTRAINT [FK_Liquidations_Head];
GO
IF OBJECT_ID(N'[dbo].[FK_Liquidations_Obligations]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Liquidations] DROP CONSTRAINT [FK_Liquidations_Obligations];
GO
IF OBJECT_ID(N'[dbo].[FK_Liquidations_Payees]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Liquidations] DROP CONSTRAINT [FK_Liquidations_Payees];
GO
IF OBJECT_ID(N'[dbo].[FK_Logs_Users]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Logs] DROP CONSTRAINT [FK_Logs_Users];
GO
IF OBJECT_ID(N'[dbo].[FK_Obligations_Offices]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Obligations] DROP CONSTRAINT [FK_Obligations_Offices];
GO
IF OBJECT_ID(N'[dbo].[FK_Obligations_Payees]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Obligations] DROP CONSTRAINT [FK_Obligations_Payees];
GO
IF OBJECT_ID(N'[dbo].[FK_Obligations_PurchaseOrders]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Obligations] DROP CONSTRAINT [FK_Obligations_PurchaseOrders];
GO
IF OBJECT_ID(N'[dbo].[FK_Obligations_Users]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Obligations] DROP CONSTRAINT [FK_Obligations_Users];
GO
IF OBJECT_ID(N'[dbo].[FK_OBRInLetters_Letters]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OBRInLetters] DROP CONSTRAINT [FK_OBRInLetters_Letters];
GO
IF OBJECT_ID(N'[dbo].[FK_OBRInLetters_Obligations]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OBRInLetters] DROP CONSTRAINT [FK_OBRInLetters_Obligations];
GO
IF OBJECT_ID(N'[dbo].[FK_Offices_Offices]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Offices] DROP CONSTRAINT [FK_Offices_Offices];
GO
IF OBJECT_ID(N'[dbo].[FK_ORDetails_Appropriations]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ORDetails] DROP CONSTRAINT [FK_ORDetails_Appropriations];
GO
IF OBJECT_ID(N'[dbo].[FK_ORDetails_Obligations]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ORDetails] DROP CONSTRAINT [FK_ORDetails_Obligations];
GO
IF OBJECT_ID(N'[dbo].[FK_PAR_PurchaseRequests]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PAR] DROP CONSTRAINT [FK_PAR_PurchaseRequests];
GO
IF OBJECT_ID(N'[dbo].[FK_PARDetails_PAR]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PARDetails] DROP CONSTRAINT [FK_PARDetails_PAR];
GO
IF OBJECT_ID(N'[dbo].[FK_Payees_Offices]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Payees] DROP CONSTRAINT [FK_Payees_Offices];
GO
IF OBJECT_ID(N'[dbo].[FK_PayrollDetails_Employees]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PayrollDetails] DROP CONSTRAINT [FK_PayrollDetails_Employees];
GO
IF OBJECT_ID(N'[dbo].[FK_PayrollDetails_Payrolls]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PayrollDetails] DROP CONSTRAINT [FK_PayrollDetails_Payrolls];
GO
IF OBJECT_ID(N'[dbo].[FK_PayrollDifferentialDetails_Employees]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PayrollDifferentialDetails] DROP CONSTRAINT [FK_PayrollDifferentialDetails_Employees];
GO
IF OBJECT_ID(N'[dbo].[FK_PayrollDifferentialDetails_PayrollDifferentials]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PayrollDifferentialDetails] DROP CONSTRAINT [FK_PayrollDifferentialDetails_PayrollDifferentials];
GO
IF OBJECT_ID(N'[dbo].[FK_PayrollDifferentials_Obligations]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PayrollDifferentials] DROP CONSTRAINT [FK_PayrollDifferentials_Obligations];
GO
IF OBJECT_ID(N'[dbo].[FK_PayrollOT_Obligations]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PayrollOT] DROP CONSTRAINT [FK_PayrollOT_Obligations];
GO
IF OBJECT_ID(N'[dbo].[FK_PayrollOTDetails_Employees]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PayrollOTDetails] DROP CONSTRAINT [FK_PayrollOTDetails_Employees];
GO
IF OBJECT_ID(N'[dbo].[FK_PayrollOTDetails_PayrollOT]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PayrollOTDetails] DROP CONSTRAINT [FK_PayrollOTDetails_PayrollOT];
GO
IF OBJECT_ID(N'[dbo].[FK_Payrolls_Obligations]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Payrolls] DROP CONSTRAINT [FK_Payrolls_Obligations];
GO
IF OBJECT_ID(N'[dbo].[FK_PayrollWage_Obligations]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PayrollWages] DROP CONSTRAINT [FK_PayrollWage_Obligations];
GO
IF OBJECT_ID(N'[dbo].[FK_PayrollWageDetails_PayrollWages]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PayrollWageDetails] DROP CONSTRAINT [FK_PayrollWageDetails_PayrollWages];
GO
IF OBJECT_ID(N'[dbo].[FK_PayrollWages_Employees]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PayrollWageDetails] DROP CONSTRAINT [FK_PayrollWages_Employees];
GO
IF OBJECT_ID(N'[dbo].[FK_PIS_PurchaseRequests]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PIS] DROP CONSTRAINT [FK_PIS_PurchaseRequests];
GO
IF OBJECT_ID(N'[dbo].[FK_PIS_Users]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PIS] DROP CONSTRAINT [FK_PIS_Users];
GO
IF OBJECT_ID(N'[dbo].[FK_PISDetails_PIS]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PISDetails] DROP CONSTRAINT [FK_PISDetails_PIS];
GO
IF OBJECT_ID(N'[dbo].[FK_PODetails_PurchaseOrders]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PODetails] DROP CONSTRAINT [FK_PODetails_PurchaseOrders];
GO
IF OBJECT_ID(N'[dbo].[FK_PQDetails_PurchaseQuotations]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PQDetails] DROP CONSTRAINT [FK_PQDetails_PurchaseQuotations];
GO
IF OBJECT_ID(N'[dbo].[FK_PRDetails_Items]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PRDetails] DROP CONSTRAINT [FK_PRDetails_Items];
GO
IF OBJECT_ID(N'[dbo].[FK_PRDetails_PurchaseRequests]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PRDetails] DROP CONSTRAINT [FK_PRDetails_PurchaseRequests];
GO
IF OBJECT_ID(N'[dbo].[FK_PurchaseOrders_PurchaseRequests]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PurchaseOrders] DROP CONSTRAINT [FK_PurchaseOrders_PurchaseRequests];
GO
IF OBJECT_ID(N'[dbo].[FK_PurchaseQuotations_PurchaseRequests]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PriceQuotations] DROP CONSTRAINT [FK_PurchaseQuotations_PurchaseRequests];
GO
IF OBJECT_ID(N'[dbo].[FK_PurchaseRequests_Appropriations]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PurchaseRequests] DROP CONSTRAINT [FK_PurchaseRequests_Appropriations];
GO
IF OBJECT_ID(N'[dbo].[FK_PurchaseRequests_Offices]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PurchaseRequests] DROP CONSTRAINT [FK_PurchaseRequests_Offices];
GO
IF OBJECT_ID(N'[dbo].[FK_ReAlignments_Appropriations]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ReAlignments] DROP CONSTRAINT [FK_ReAlignments_Appropriations];
GO
IF OBJECT_ID(N'[dbo].[FK_ReAlignments_TargetSource]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ReAlignments] DROP CONSTRAINT [FK_ReAlignments_TargetSource];
GO
IF OBJECT_ID(N'[dbo].[FK_RISDetails_RISHeader]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RISDetails] DROP CONSTRAINT [FK_RISDetails_RISHeader];
GO
IF OBJECT_ID(N'[dbo].[FK_RISHeader_Offices]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RISHeader] DROP CONSTRAINT [FK_RISHeader_Offices];
GO
IF OBJECT_ID(N'[dbo].[FK_RISHeader_PurchaseRequests]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RISHeader] DROP CONSTRAINT [FK_RISHeader_PurchaseRequests];
GO
IF OBJECT_ID(N'[dbo].[FK_Signatories_Employees]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Signatories] DROP CONSTRAINT [FK_Signatories_Employees];
GO
IF OBJECT_ID(N'[dbo].[FK_Towns_Towns]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Towns] DROP CONSTRAINT [FK_Towns_Towns];
GO
IF OBJECT_ID(N'[dbo].[FK_TrashBin_Offices]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TrashBin] DROP CONSTRAINT [FK_TrashBin_Offices];
GO
IF OBJECT_ID(N'[dbo].[FK_TrashBin_TrashBin]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TrashBin] DROP CONSTRAINT [FK_TrashBin_TrashBin];
GO
IF OBJECT_ID(N'[dbo].[FK_UserClaims_Users]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserClaims] DROP CONSTRAINT [FK_UserClaims_Users];
GO
IF OBJECT_ID(N'[dbo].[FK_UserLogins_Users]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserLogins] DROP CONSTRAINT [FK_UserLogins_Users];
GO
IF OBJECT_ID(N'[dbo].[FK_UserRolesInFunctions_Functions]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserRolesInFunctions] DROP CONSTRAINT [FK_UserRolesInFunctions_Functions];
GO
IF OBJECT_ID(N'[dbo].[FK_UserRolesInFunctions_UserRoles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserRolesInFunctions] DROP CONSTRAINT [FK_UserRolesInFunctions_UserRoles];
GO
IF OBJECT_ID(N'[dbo].[FK_Users_Offices]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Users] DROP CONSTRAINT [FK_Users_Offices];
GO
IF OBJECT_ID(N'[dbo].[FK_UsersInDocumentActions_DocumentActions]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UsersInDocumentActions] DROP CONSTRAINT [FK_UsersInDocumentActions_DocumentActions];
GO
IF OBJECT_ID(N'[dbo].[FK_UsersInDocumentActions_Users]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UsersInDocumentActions] DROP CONSTRAINT [FK_UsersInDocumentActions_Users];
GO
IF OBJECT_ID(N'[dbo].[FK_UsersInRoles_UserRoles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UsersInRoles] DROP CONSTRAINT [FK_UsersInRoles_UserRoles];
GO
IF OBJECT_ID(N'[dbo].[FK_UsersInRoles_Users]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UsersInRoles] DROP CONSTRAINT [FK_UsersInRoles_Users];
GO
IF OBJECT_ID(N'[dbo].[FK_Years_Offices]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Years] DROP CONSTRAINT [FK_Years_Offices];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Actions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Actions];
GO
IF OBJECT_ID(N'[dbo].[ActionTakens]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ActionTakens];
GO
IF OBJECT_ID(N'[dbo].[AIRDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AIRDetails];
GO
IF OBJECT_ID(N'[dbo].[AIReports]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AIReports];
GO
IF OBJECT_ID(N'[dbo].[AllotmentLetter]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AllotmentLetter];
GO
IF OBJECT_ID(N'[dbo].[Allotments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Allotments];
GO
IF OBJECT_ID(N'[dbo].[AOQ]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AOQ];
GO
IF OBJECT_ID(N'[dbo].[AOQDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AOQDetails];
GO
IF OBJECT_ID(N'[dbo].[Appropriations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Appropriations];
GO
IF OBJECT_ID(N'[dbo].[APRDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[APRDetails];
GO
IF OBJECT_ID(N'[dbo].[APRs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[APRs];
GO
IF OBJECT_ID(N'[dbo].[BACInAOQ]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BACInAOQ];
GO
IF OBJECT_ID(N'[dbo].[BACMembers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BACMembers];
GO
IF OBJECT_ID(N'[dbo].[Categories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Categories];
GO
IF OBJECT_ID(N'[dbo].[ControlNumbers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ControlNumbers];
GO
IF OBJECT_ID(N'[dbo].[DefaultAccounts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DefaultAccounts];
GO
IF OBJECT_ID(N'[dbo].[DefaultSettings]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DefaultSettings];
GO
IF OBJECT_ID(N'[dbo].[DocumentActions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DocumentActions];
GO
IF OBJECT_ID(N'[dbo].[Employees]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employees];
GO
IF OBJECT_ID(N'[dbo].[EmployeesInPayee]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmployeesInPayee];
GO
IF OBJECT_ID(N'[dbo].[Files]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Files];
GO
IF OBJECT_ID(N'[dbo].[Functions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Functions];
GO
IF OBJECT_ID(N'[dbo].[FundTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FundTypes];
GO
IF OBJECT_ID(N'[dbo].[ICS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ICS];
GO
IF OBJECT_ID(N'[dbo].[ICSDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ICSDetails];
GO
IF OBJECT_ID(N'[dbo].[Items]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Items];
GO
IF OBJECT_ID(N'[dbo].[ItenaryDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ItenaryDetails];
GO
IF OBJECT_ID(N'[dbo].[ItenaryofTravels]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ItenaryofTravels];
GO
IF OBJECT_ID(N'[dbo].[Letters]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Letters];
GO
IF OBJECT_ID(N'[dbo].[Liquidations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Liquidations];
GO
IF OBJECT_ID(N'[dbo].[Logs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Logs];
GO
IF OBJECT_ID(N'[dbo].[Obligations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Obligations];
GO
IF OBJECT_ID(N'[dbo].[OBRInLetters]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OBRInLetters];
GO
IF OBJECT_ID(N'[dbo].[Offices]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Offices];
GO
IF OBJECT_ID(N'[dbo].[ORDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ORDetails];
GO
IF OBJECT_ID(N'[dbo].[PAR]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PAR];
GO
IF OBJECT_ID(N'[dbo].[PARDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PARDetails];
GO
IF OBJECT_ID(N'[dbo].[Payees]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Payees];
GO
IF OBJECT_ID(N'[dbo].[PayrollDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PayrollDetails];
GO
IF OBJECT_ID(N'[dbo].[PayrollDifferentialDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PayrollDifferentialDetails];
GO
IF OBJECT_ID(N'[dbo].[PayrollDifferentials]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PayrollDifferentials];
GO
IF OBJECT_ID(N'[dbo].[PayrollOT]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PayrollOT];
GO
IF OBJECT_ID(N'[dbo].[PayrollOTDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PayrollOTDetails];
GO
IF OBJECT_ID(N'[dbo].[Payrolls]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Payrolls];
GO
IF OBJECT_ID(N'[dbo].[PayrollWageDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PayrollWageDetails];
GO
IF OBJECT_ID(N'[dbo].[PayrollWages]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PayrollWages];
GO
IF OBJECT_ID(N'[dbo].[PIS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PIS];
GO
IF OBJECT_ID(N'[dbo].[PISDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PISDetails];
GO
IF OBJECT_ID(N'[dbo].[PODetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PODetails];
GO
IF OBJECT_ID(N'[dbo].[Positions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Positions];
GO
IF OBJECT_ID(N'[dbo].[PQDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PQDetails];
GO
IF OBJECT_ID(N'[dbo].[PRDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PRDetails];
GO
IF OBJECT_ID(N'[dbo].[PriceQuotations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PriceQuotations];
GO
IF OBJECT_ID(N'[dbo].[Provinces]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Provinces];
GO
IF OBJECT_ID(N'[dbo].[PurchaseOrders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PurchaseOrders];
GO
IF OBJECT_ID(N'[dbo].[PurchaseRequests]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PurchaseRequests];
GO
IF OBJECT_ID(N'[dbo].[ReAlignments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ReAlignments];
GO
IF OBJECT_ID(N'[dbo].[RISDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RISDetails];
GO
IF OBJECT_ID(N'[dbo].[RISHeader]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RISHeader];
GO
IF OBJECT_ID(N'[dbo].[SalarySchedules]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SalarySchedules];
GO
IF OBJECT_ID(N'[dbo].[Signatories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Signatories];
GO
IF OBJECT_ID(N'[dbo].[Suppliers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Suppliers];
GO
IF OBJECT_ID(N'[dbo].[Templates]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Templates];
GO
IF OBJECT_ID(N'[dbo].[Towns]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Towns];
GO
IF OBJECT_ID(N'[dbo].[TrashBin]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TrashBin];
GO
IF OBJECT_ID(N'[dbo].[UserClaims]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserClaims];
GO
IF OBJECT_ID(N'[dbo].[UserLogins]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserLogins];
GO
IF OBJECT_ID(N'[dbo].[UserRoles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserRoles];
GO
IF OBJECT_ID(N'[dbo].[UserRolesInFunctions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserRolesInFunctions];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[UsersInDocumentActions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UsersInDocumentActions];
GO
IF OBJECT_ID(N'[dbo].[UsersInRoles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UsersInRoles];
GO
IF OBJECT_ID(N'[dbo].[Years]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Years];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Allotments'
CREATE TABLE [dbo].[Allotments] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [AppropriationId] int  NULL,
    [AllotmentDate] datetime  NULL,
    [AllotmentAmount] decimal(19,4)  NULL,
    [Remarks] nvarchar(max)  NULL,
    [DateCreated] datetime  NULL,
    [CreatedB] nvarchar(128)  NULL
);
GO

-- Creating table 'Appropriations'
CREATE TABLE [dbo].[Appropriations] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [AccountCode] nvarchar(128)  NULL,
    [AccountCodeText] nvarchar(128)  NULL,
    [FundType] nvarchar(50)  NULL,
    [FundTypeId] int  NULL,
    [AccountName] nvarchar(128)  NULL,
    [Appropriation] decimal(19,4)  NULL,
    [Year] int  NULL,
    [DateCreated] datetime  NULL,
    [Createdby] nvarchar(128)  NULL,
    [OfficeId] int  NULL,
    [FT] nvarchar(5)  NULL
);
GO

-- Creating table 'Categories'
CREATE TABLE [dbo].[Categories] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Category] nvarchar(128)  NULL
);
GO

-- Creating table 'DefaultAccounts'
CREATE TABLE [dbo].[DefaultAccounts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [AccountCode] nvarchar(128)  NULL,
    [AccountCodeText] nvarchar(128)  NULL,
    [AccountName] nvarchar(max)  NULL,
    [FundType] nvarchar(128)  NULL,
    [FundTypeId] int  NULL
);
GO

-- Creating table 'DefaultSettings'
CREATE TABLE [dbo].[DefaultSettings] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Year] int  NULL,
    [Department] nvarchar(max)  NULL,
    [ChiefOfOffice] nvarchar(max)  NULL,
    [ChiefOfOfficePos] nvarchar(max)  NULL,
    [ResponsibilityCenter] nvarchar(max)  NULL,
    [ResponsibilityCenterCode] nvarchar(max)  NULL,
    [OfficeId] nvarchar(max)  NULL,
    [IsDepartment] bit  NULL,
    [UnderOf] nvarchar(max)  NULL
);
GO

-- Creating table 'Employees'
CREATE TABLE [dbo].[Employees] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(128)  NULL,
    [MiddleName] nvarchar(128)  NULL,
    [LastName] nvarchar(128)  NULL,
    [Position] nvarchar(128)  NULL,
    [OfficeName] nvarchar(128)  NULL,
    [OffcAcr] nvarchar(128)  NULL,
    [OfficeId] int  NULL,
    [TIN] nvarchar(128)  NULL,
    [PagIbig] nvarchar(128)  NULL,
    [PhilHealth] nvarchar(128)  NULL,
    [Status] nvarchar(20)  NULL,
    [Salutation] nvarchar(20)  NULL,
    [SG] nvarchar(20)  NULL,
    [SSS] nvarchar(128)  NULL,
    [ExtName] nvarchar(5)  NULL,
    [GSIS] nvarchar(20)  NULL,
    [SalaryGrade] nvarchar(20)  NULL,
    [Steps] nvarchar(20)  NULL
);
GO

-- Creating table 'Functions'
CREATE TABLE [dbo].[Functions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Action] nvarchar(255)  NULL
);
GO

-- Creating table 'FundTypes'
CREATE TABLE [dbo].[FundTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FundType] nvarchar(50)  NULL,
    [Description] nvarchar(max)  NULL,
    [ItemNumber] int  NULL
);
GO

-- Creating table 'Items'
CREATE TABLE [dbo].[Items] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Category] nvarchar(128)  NULL,
    [Item] nvarchar(255)  NULL,
    [UOM] nvarchar(50)  NULL,
    [Cost] decimal(19,4)  NULL,
    [DateCreated] datetime  NULL
);
GO

-- Creating table 'Logs'
CREATE TABLE [dbo].[Logs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TableName] nvarchar(max)  NULL,
    [OldValues] nvarchar(max)  NULL,
    [NewValues] nvarchar(max)  NULL,
    [Action] nvarchar(max)  NULL,
    [DateCreated] datetime  NULL,
    [CreatedBy] nvarchar(128)  NULL
);
GO

-- Creating table 'Obligations'
CREATE TABLE [dbo].[Obligations] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Date] datetime  NULL,
    [ControlNo] nvarchar(100)  NULL,
    [BudgetControlNo] nvarchar(100)  NULL,
    [PayeeId] int  NULL,
    [PayeeOffice] nvarchar(255)  NULL,
    [PayeeAddress] nvarchar(255)  NULL,
    [Chief] nvarchar(100)  NULL,
    [ChiefPosition] nvarchar(255)  NULL,
    [PBOPos] nvarchar(100)  NULL,
    [PBO] nvarchar(100)  NULL,
    [Closed] bit  NULL,
    [Description] nvarchar(255)  NULL,
    [DVParticular] nvarchar(max)  NULL,
    [DVApprovedBy] nvarchar(100)  NULL,
    [DVApprovedByPosition] nvarchar(100)  NULL,
    [DVNote] nvarchar(255)  NULL,
    [Status] nvarchar(100)  NULL,
    [DateClosed] datetime  NULL,
    [Earmarked] bit  NULL,
    [PRNo] int  NULL,
    [SSMA_TimeStamp] binary(8)  NOT NULL,
    [Amount] decimal(19,4)  NOT NULL,
    [Year] int  NULL,
    [ResponsibilityCenter] nvarchar(50)  NULL,
    [ResponsibilityCenterCode] nvarchar(50)  NULL,
    [OfficeId] int  NULL,
    [Treasurer] nvarchar(128)  NULL,
    [TreasurerPos] nvarchar(128)  NULL,
    [Accountant] nvarchar(128)  NULL,
    [AccountantPos] nvarchar(128)  NULL,
    [OBRApprovedBy] nvarchar(128)  NULL,
    [OBRApprovedByPos] nvarchar(128)  NULL,
    [DMSNo] nvarchar(100)  NULL,
    [CreatedBy] nvarchar(128)  NULL,
    [DateCreated] datetime  NULL,
    [ModifiedBy] nvarchar(128)  NULL,
    [DateModified] datetime  NULL,
    [ModifiedData] nvarchar(max)  NULL,
    [TotalAdjustedAmount] decimal(19,4)  NULL,
    [POId] int  NULL,
    [DVAmount] decimal(19,4)  NULL,
    [FT] nvarchar(5)  NULL,
    [IsCancelled] bit  NOT NULL,
    [CancelReason] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Offices'
CREATE TABLE [dbo].[Offices] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [OffcAcr] nvarchar(50)  NULL,
    [OfficeName] nvarchar(128)  NULL,
    [Chief] nvarchar(128)  NULL,
    [ChiefPosition] nvarchar(128)  NULL,
    [ResponsibilityCenter] nvarchar(128)  NULL,
    [ResponsibilityCenterCode] nvarchar(128)  NULL,
    [IsDivision] bit  NULL,
    [UnderOf] int  NULL,
    [CreatedBy] nvarchar(50)  NULL,
    [DateCreated] datetime  NULL,
    [Address] nvarchar(max)  NULL,
    [TelNo] nvarchar(max)  NULL,
    [Salutation] nvarchar(50)  NULL,
    [InsideAddress] nvarchar(max)  NULL
);
GO

-- Creating table 'Payees'
CREATE TABLE [dbo].[Payees] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(128)  NULL,
    [Office] nvarchar(128)  NULL,
    [Address] nvarchar(128)  NULL,
    [Note] nvarchar(128)  NULL,
    [OfficeId] int  NULL
);
GO

-- Creating table 'PayrollDetails'
CREATE TABLE [dbo].[PayrollDetails] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PayrollId] int  NULL,
    [ItemNumber] int  NULL,
    [EmployeeId] int  NULL,
    [Name] nvarchar(max)  NULL,
    [Designation] nvarchar(max)  NULL,
    [ColumnTitle1] decimal(19,4)  NULL,
    [ColumnTitle2] decimal(19,4)  NULL,
    [Total] decimal(19,4)  NULL,
    [ColumnTitle] nvarchar(max)  NULL
);
GO

-- Creating table 'Positions'
CREATE TABLE [dbo].[Positions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Position] nvarchar(128)  NULL,
    [Description] nvarchar(128)  NULL
);
GO

-- Creating table 'PRDetails'
CREATE TABLE [dbo].[PRDetails] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PRId] int  NULL,
    [ItemNo] int  NULL,
    [Quantity] decimal(19,4)  NULL,
    [Category] nvarchar(50)  NULL,
    [Item] nvarchar(max)  NULL,
    [UOM] nvarchar(50)  NULL,
    [Cost] decimal(19,4)  NULL,
    [TotalAmount] decimal(19,4)  NULL,
    [TableName] nvarchar(128)  NULL,
    [ItemId] int  NULL
);
GO

-- Creating table 'PriceQuotations'
CREATE TABLE [dbo].[PriceQuotations] (
    [Id] int  NOT NULL,
    [PRId] int  NULL,
    [Date] datetime  NULL,
    [ControlNo] nvarchar(128)  NULL,
    [Description] nvarchar(max)  NULL,
    [Purpose] nvarchar(max)  NULL,
    [TotalAmount] decimal(19,4)  NULL,
    [PGSOfficer] nvarchar(max)  NULL,
    [Position] nvarchar(max)  NULL,
    [Office] nvarchar(max)  NULL
);
GO

-- Creating table 'Provinces'
CREATE TABLE [dbo].[Provinces] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NULL,
    [SortOrder] nchar(10)  NULL
);
GO

-- Creating table 'PurchaseOrders'
CREATE TABLE [dbo].[PurchaseOrders] (
    [Id] int  NOT NULL,
    [PRId] int  NULL,
    [Date] datetime  NULL,
    [ControlNo] nvarchar(128)  NULL,
    [Description] nvarchar(max)  NULL,
    [Purpose] nvarchar(max)  NULL,
    [TotalAmount] decimal(19,4)  NULL,
    [PGSOfficer] nvarchar(max)  NULL,
    [Position] nvarchar(max)  NULL,
    [Supplier] nvarchar(max)  NULL,
    [SupplierAddress] nvarchar(max)  NULL,
    [PONo] nvarchar(128)  NULL,
    [PODate] datetime  NULL,
    [ModeOfProcurement] nvarchar(128)  NULL,
    [PRNo] nvarchar(128)  NULL,
    [PlaceOfDelivery] nvarchar(128)  NULL,
    [DateOfDelivery] datetime  NULL,
    [DeliveryTerm] nvarchar(128)  NULL,
    [PaymentTerm] nvarchar(128)  NULL
);
GO

-- Creating table 'ReAlignments'
CREATE TABLE [dbo].[ReAlignments] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Date] datetime  NULL,
    [SourceAppropriationId] int  NULL,
    [TargetAppropriationId] int  NULL,
    [Amount] decimal(19,4)  NULL,
    [Remarks] nvarchar(max)  NULL,
    [DateCreated] datetime  NULL,
    [CreatedBy] nvarchar(128)  NULL
);
GO

-- Creating table 'Signatories'
CREATE TABLE [dbo].[Signatories] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Person] nvarchar(max)  NULL,
    [Position] nvarchar(max)  NULL,
    [Note] nvarchar(max)  NULL,
    [Year] int  NULL,
    [Office] nvarchar(max)  NULL,
    [IsBacMember] bit  NULL,
    [BacPosition] nvarchar(max)  NULL,
    [EmployeeId] int  NULL
);
GO

-- Creating table 'Suppliers'
CREATE TABLE [dbo].[Suppliers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SupplierName] nvarchar(max)  NULL,
    [Address] nvarchar(max)  NULL,
    [ContactNumber] nvarchar(max)  NULL,
    [PhoneNumber] nvarchar(max)  NULL,
    [FaxNumber] nvarchar(max)  NULL,
    [CellNumber] nvarchar(max)  NULL,
    [Status] bit  NULL
);
GO

-- Creating table 'Towns'
CREATE TABLE [dbo].[Towns] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NULL,
    [ProvinceId] int  NULL,
    [SortOrder] int  NULL
);
GO

-- Creating table 'UserClaims'
CREATE TABLE [dbo].[UserClaims] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserId] nvarchar(128)  NOT NULL,
    [ClaimType] nvarchar(max)  NULL,
    [ClaimValue] nvarchar(max)  NULL
);
GO

-- Creating table 'UserLogins'
CREATE TABLE [dbo].[UserLogins] (
    [LoginProvider] nvarchar(128)  NOT NULL,
    [ProviderKey] nvarchar(128)  NOT NULL,
    [UserId] nvarchar(128)  NOT NULL
);
GO

-- Creating table 'UserRoles'
CREATE TABLE [dbo].[UserRoles] (
    [Id] nvarchar(128)  NOT NULL,
    [Name] nvarchar(50)  NULL,
    [Description] nvarchar(max)  NULL
);
GO

-- Creating table 'Years'
CREATE TABLE [dbo].[Years] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Year] int  NULL,
    [IsActive] bit  NULL,
    [OfficeId] int  NULL
);
GO

-- Creating table 'Payrolls'
CREATE TABLE [dbo].[Payrolls] (
    [Id] int  NOT NULL,
    [Date] datetime  NULL,
    [ControlNo] nvarchar(128)  NULL,
    [Description] nvarchar(max)  NULL,
    [Title] nvarchar(128)  NULL,
    [ColumnTitle1] nvarchar(128)  NULL,
    [ColumnTitle2] nvarchar(128)  NULL,
    [ChiefOfOffice] nvarchar(128)  NULL,
    [Position] nvarchar(128)  NULL,
    [Accountant] nvarchar(128)  NULL,
    [AccountantPos] nvarchar(128)  NULL,
    [Treasurer] nvarchar(128)  NULL,
    [TreasurerPos] nvarchar(128)  NULL,
    [ApprovedBy] nvarchar(128)  NULL,
    [ApprovedByPos] nvarchar(128)  NULL,
    [ApprovedById] int  NULL,
    [DeptHead] nvarchar(128)  NULL,
    [DeptHeadPos] nvarchar(128)  NULL
);
GO

-- Creating table 'PayrollWages'
CREATE TABLE [dbo].[PayrollWages] (
    [Id] int  NOT NULL,
    [Date] datetime  NULL,
    [ControlNo] nvarchar(128)  NULL,
    [Description] nvarchar(max)  NULL,
    [Title] nvarchar(128)  NULL,
    [ChiefOfOffice] nvarchar(128)  NULL,
    [Position] nvarchar(128)  NULL,
    [Accountant] nvarchar(128)  NULL,
    [AccountantPos] nvarchar(128)  NULL,
    [Treasurer] nvarchar(128)  NULL,
    [TreasurerPos] nvarchar(128)  NULL,
    [ApprovedBy] nvarchar(128)  NULL,
    [ApprovedByPos] nvarchar(128)  NULL,
    [ApprovedById] int  NULL,
    [ColumnTitles] nvarchar(max)  NULL
);
GO

-- Creating table 'BACMembers'
CREATE TABLE [dbo].[BACMembers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [OfficeId] int  NULL,
    [EmployeeId] int  NULL,
    [FirstName] nvarchar(128)  NULL,
    [MiddleName] nvarchar(128)  NULL,
    [LastName] nvarchar(128)  NULL,
    [Position] nvarchar(128)  NULL,
    [OfficeName] nvarchar(128)  NULL,
    [OffcAcr] nvarchar(128)  NULL
);
GO

-- Creating table 'AllotmentLetter'
CREATE TABLE [dbo].[AllotmentLetter] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PRId] int  NULL,
    [Reason] nvarchar(max)  NULL,
    [CreatedBy] nvarchar(max)  NULL,
    [DateCreated] datetime  NULL,
    [Letter] nvarchar(max)  NULL,
    [HeadofDivision] nvarchar(max)  NULL,
    [HeadofDivisionPOS] nvarchar(max)  NULL,
    [PBO] nvarchar(max)  NULL,
    [PBOPos] nvarchar(max)  NULL,
    [AccountCode] nvarchar(max)  NULL,
    [AccountName] nvarchar(max)  NULL,
    [AppropriationId] int  NULL
);
GO

-- Creating table 'ControlNumbers'
CREATE TABLE [dbo].[ControlNumbers] (
    [Id] int  NOT NULL,
    [ControlNo] nvarchar(128)  NULL,
    [OfficeId] int  NULL,
    [TableName] nvarchar(128)  NULL
);
GO

-- Creating table 'PayrollWageDetails'
CREATE TABLE [dbo].[PayrollWageDetails] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ItemNumber] int  NULL,
    [PayrollWageId] int  NULL,
    [EmployeeId] int  NULL,
    [NoOfdays] decimal(19,4)  NULL,
    [RatePerDay] decimal(19,4)  NULL,
    [GrossAmount] decimal(19,4)  NULL,
    [PERA] decimal(19,4)  NULL,
    [PHPS] decimal(19,4)  NULL,
    [PHGS] decimal(19,4)  NULL,
    [PIPS] decimal(19,4)  NULL,
    [PIGS] decimal(19,4)  NULL,
    [Total] decimal(19,4)  NULL,
    [MPL] decimal(19,4)  NULL,
    [PIFCalLoan] decimal(19,4)  NULL,
    [NVPEA] decimal(19,4)  NULL,
    [SSSLoan] decimal(19,4)  NULL,
    [LBP] decimal(19,4)  NULL,
    [DBP] decimal(19,4)  NULL,
    [BIRWH] decimal(19,4)  NULL,
    [GSISPolicy] decimal(19,4)  NULL,
    [GSISConsol] decimal(19,4)  NULL,
    [SSSPS] decimal(19,4)  NULL,
    [OT] decimal(19,4)  NULL
);
GO

-- Creating table 'Templates'
CREATE TABLE [dbo].[Templates] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NULL,
    [TemplateContent] nvarchar(max)  NULL,
    [Type] nvarchar(max)  NULL,
    [OfficeId] int  NULL
);
GO

-- Creating table 'SalarySchedules'
CREATE TABLE [dbo].[SalarySchedules] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SG] nvarchar(50)  NULL,
    [Step] int  NULL,
    [Cost] decimal(19,4)  NULL
);
GO

-- Creating table 'PayrollDifferentials'
CREATE TABLE [dbo].[PayrollDifferentials] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Date] datetime  NULL,
    [ControlNo] nvarchar(128)  NULL,
    [Description] nvarchar(max)  NULL,
    [Title] nvarchar(128)  NULL,
    [ChiefOfOffice] nvarchar(128)  NULL,
    [Position] nvarchar(128)  NULL,
    [Accountant] nvarchar(128)  NULL,
    [AccountantPos] nvarchar(128)  NULL,
    [Treasurer] nvarchar(128)  NULL,
    [TreasurerPos] nvarchar(128)  NULL,
    [ApprovedBy] nvarchar(128)  NULL,
    [ApprovedByPos] nvarchar(128)  NULL,
    [ApprovedById] int  NULL,
    [ObId] int  NULL
);
GO

-- Creating table 'ORDetails'
CREATE TABLE [dbo].[ORDetails] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [AppropriationId] int  NULL,
    [ObligationId] int  NULL,
    [Particulars] nvarchar(max)  NULL,
    [Amount] decimal(19,4)  NULL,
    [AdjustedAmount] decimal(19,4)  NULL
);
GO

-- Creating table 'PODetails'
CREATE TABLE [dbo].[PODetails] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [POId] int  NOT NULL,
    [ItemNo] int  NOT NULL,
    [Quantity] decimal(19,4)  NOT NULL,
    [Category] nvarchar(50)  NOT NULL,
    [Item] nvarchar(max)  NOT NULL,
    [UOM] nvarchar(50)  NOT NULL,
    [Cost] decimal(19,4)  NOT NULL,
    [TotalAmount] decimal(19,4)  NOT NULL
);
GO

-- Creating table 'PQDetails'
CREATE TABLE [dbo].[PQDetails] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PQId] int  NULL,
    [ItemNo] int  NULL,
    [Quantity] decimal(19,4)  NULL,
    [Category] nvarchar(50)  NULL,
    [Item] nvarchar(max)  NULL,
    [UOM] nvarchar(50)  NULL,
    [Cost] decimal(19,4)  NULL,
    [TotalAmount] decimal(19,4)  NULL
);
GO

-- Creating table 'AOQ'
CREATE TABLE [dbo].[AOQ] (
    [Id] int  NOT NULL,
    [PRId] int  NULL,
    [Date] datetime  NULL,
    [ControlNo] nvarchar(128)  NULL,
    [Description] nvarchar(max)  NULL,
    [Purpose] nvarchar(max)  NULL,
    [NameofProject] nvarchar(max)  NULL,
    [RequisitioningOffice] nvarchar(max)  NULL,
    [ABC] decimal(19,4)  NULL,
    [RFQNo] int  NULL,
    [CreatedBy] nvarchar(max)  NULL,
    [CreatedById] nvarchar(128)  NULL,
    [OfficeId] int  NULL,
    [Head] nvarchar(max)  NULL,
    [HeadPosition] nvarchar(max)  NULL,
    [BACChairperson] int  NULL
);
GO

-- Creating table 'AOQDetails'
CREATE TABLE [dbo].[AOQDetails] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [AOQId] int  NULL,
    [ItemNo] int  NULL,
    [Quantity] decimal(19,4)  NULL,
    [Category] nvarchar(50)  NULL,
    [Item] nvarchar(max)  NULL,
    [UOM] nvarchar(50)  NULL,
    [Cost] decimal(19,4)  NULL,
    [TotalAmount] decimal(19,4)  NULL,
    [CreatedBy] nvarchar(255)  NULL,
    [CreatedById] nvarchar(255)  NULL
);
GO

-- Creating table 'APRs'
CREATE TABLE [dbo].[APRs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PRId] int  NULL,
    [ControlNo] nvarchar(128)  NULL,
    [Date] datetime  NULL,
    [Name] nvarchar(max)  NULL,
    [Address] nvarchar(max)  NULL,
    [PGSOId] int  NULL,
    [AccountantId] int  NULL,
    [GovernorId] int  NULL,
    [CreatedBy] nvarchar(128)  NULL,
    [DateCreated] datetime  NULL,
    [ModifiedBy] nvarchar(128)  NULL,
    [DateModified] datetime  NULL
);
GO

-- Creating table 'APRDetails'
CREATE TABLE [dbo].[APRDetails] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [APRId] int  NULL,
    [ItemNo] int  NULL,
    [Quantity] decimal(19,4)  NULL,
    [Category] nvarchar(50)  NULL,
    [Item] nvarchar(max)  NULL,
    [UOM] nvarchar(50)  NULL,
    [Cost] decimal(19,4)  NULL,
    [TotalAmount] decimal(19,4)  NULL
);
GO

-- Creating table 'Actions'
CREATE TABLE [dbo].[Actions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ItemOrder] int  NULL,
    [Category] nvarchar(50)  NULL,
    [Value] nvarchar(max)  NULL,
    [ParentId] int  NULL,
    [OfficeId] int  NULL
);
GO

-- Creating table 'PayrollDifferentialDetails'
CREATE TABLE [dbo].[PayrollDifferentialDetails] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PayrollDiffentialId] int  NULL,
    [ItemNumber] int  NULL,
    [EmployeeId] int  NULL,
    [Designation] nvarchar(128)  NULL,
    [EmployeeName] nvarchar(128)  NULL,
    [SalaryGrade] nvarchar(128)  NULL,
    [NewRate] decimal(19,4)  NULL,
    [OldRate] decimal(19,4)  NULL,
    [Amount] decimal(19,4)  NULL,
    [DiffMidYearBonus] decimal(19,4)  NULL,
    [Month] int  NULL,
    [DiffBonus] decimal(19,4)  NULL,
    [PHPS] decimal(19,4)  NULL,
    [PHGS] decimal(19,4)  NULL,
    [PIPS] decimal(19,4)  NULL,
    [PIGS] decimal(19,4)  NULL,
    [GSISPS] decimal(19,4)  NULL,
    [GSISGS] decimal(19,4)  NULL,
    [TotalAmount] decimal(19,4)  NULL
);
GO

-- Creating table 'AIRDetails'
CREATE TABLE [dbo].[AIRDetails] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [AIReportId] int  NULL,
    [ItemNo] int  NOT NULL,
    [Quantity] decimal(19,4)  NOT NULL,
    [Category] nvarchar(50)  NOT NULL,
    [Item] nvarchar(max)  NOT NULL,
    [UOM] nvarchar(50)  NOT NULL,
    [Cost] decimal(19,4)  NOT NULL,
    [TotalAmount] decimal(19,4)  NOT NULL
);
GO

-- Creating table 'PIS'
CREATE TABLE [dbo].[PIS] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PRId] int  NULL,
    [TransferorId] int  NULL,
    [TransfereeId] int  NULL,
    [Date] datetime  NULL,
    [PreparedBy] nvarchar(128)  NULL,
    [PreparedByPos] nvarchar(128)  NULL
);
GO

-- Creating table 'PISDetails'
CREATE TABLE [dbo].[PISDetails] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PISId] int  NULL,
    [ItemNo] int  NOT NULL,
    [Quantity] decimal(19,4)  NOT NULL,
    [Category] nvarchar(50)  NOT NULL,
    [Item] nvarchar(max)  NOT NULL,
    [UOM] nvarchar(50)  NOT NULL,
    [Cost] decimal(19,4)  NOT NULL,
    [TotalAmount] decimal(19,4)  NOT NULL
);
GO

-- Creating table 'AIReports'
CREATE TABLE [dbo].[AIReports] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [POId] int  NULL,
    [PRId] int  NULL,
    [ControlNo] nvarchar(128)  NULL,
    [RISNo] int  NULL,
    [RISDate] datetime  NULL,
    [Date] datetime  NULL,
    [PropertyInspector] nvarchar(max)  NULL,
    [PropertyInspectorPosition] nvarchar(max)  NULL,
    [PropertyInspector2] nvarchar(max)  NULL,
    [PropertyInspector2Position] nvarchar(max)  NULL,
    [PGSOfficer] nvarchar(max)  NULL,
    [PGSOfficerPosition] nvarchar(max)  NULL,
    [Head] nvarchar(max)  NULL,
    [HeadPosition] nvarchar(max)  NULL,
    [PreparedBy] nvarchar(128)  NULL,
    [PropertyOfficer2] nvarchar(max)  NULL,
    [PropertyOfficerPosition2] nvarchar(max)  NULL,
    [NotedBy] nvarchar(max)  NULL,
    [NotedByPosition] nvarchar(max)  NULL,
    [PropertyOfficer] nvarchar(max)  NULL,
    [PropertyOfficerPosition] nvarchar(max)  NULL
);
GO

-- Creating table 'PurchaseRequests'
CREATE TABLE [dbo].[PurchaseRequests] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [AppropriationId] int  NULL,
    [Date] datetime  NULL,
    [ControlNo] nvarchar(128)  NULL,
    [Description] nvarchar(max)  NULL,
    [Purpose] nvarchar(max)  NULL,
    [TotalAmount] decimal(19,4)  NULL,
    [TableName] nvarchar(128)  NULL,
    [OfficeId] int  NULL,
    [PA] nvarchar(max)  NULL,
    [PAPos] nvarchar(max)  NULL,
    [DeptHead] nvarchar(max)  NULL,
    [DeptHeadPos] nvarchar(max)  NULL,
    [DivisionHead] nvarchar(max)  NULL,
    [DivisionHeadPos] nvarchar(max)  NULL,
    [CreatedBy] nvarchar(128)  NULL,
    [IsEarmark] bit  NULL,
    [BudgetControlNo] nvarchar(128)  NULL,
    [IsClosed] bit  NOT NULL,
    [Year] int  NULL,
    [IsCancelled] bit  NULL,
    [CancellationReason] nvarchar(max)  NULL,
    [FT] nvarchar(5)  NULL
);
GO

-- Creating table 'Liquidations'
CREATE TABLE [dbo].[Liquidations] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ObRId] int  NULL,
    [PayeeId] int  NULL,
    [PayeeName] nvarchar(max)  NULL,
    [PayeeAddress] nvarchar(max)  NULL,
    [PAId] int  NULL,
    [HeadOfDep] int  NULL,
    [CreatedBy] nvarchar(128)  NULL,
    [DateCreated] datetime  NULL,
    [Date] datetime  NULL,
    [Particulars] nvarchar(max)  NULL,
    [Amount] decimal(19,4)  NULL,
    [AccountantName] nvarchar(128)  NULL,
    [AccountantPosition] nvarchar(128)  NULL,
    [HeadName] nvarchar(128)  NULL,
    [HeadPosition] nvarchar(128)  NULL,
    [EmployeeId] int  NULL,
    [PeriodCovered] nvarchar(max)  NULL
);
GO

-- Creating table 'PARDetails'
CREATE TABLE [dbo].[PARDetails] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PARId] int  NULL,
    [ItemNo] int  NULL,
    [Quantity] decimal(19,4)  NULL,
    [Category] nvarchar(50)  NULL,
    [Item] nvarchar(max)  NULL,
    [UOM] nvarchar(50)  NULL,
    [Cost] decimal(19,4)  NULL,
    [TotalAmount] decimal(19,4)  NULL,
    [DateAcquired] datetime  NULL
);
GO

-- Creating table 'PAR'
CREATE TABLE [dbo].[PAR] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PRId] int  NULL,
    [EntityName] nvarchar(50)  NULL,
    [FundCluster] nvarchar(20)  NULL,
    [PGSOId] int  NULL,
    [PGSO] nvarchar(max)  NULL,
    [PGSOPosition] nvarchar(max)  NULL,
    [ReceivedById] int  NULL,
    [ReceivedBy] nvarchar(max)  NULL,
    [ReceivedByPos] nvarchar(max)  NULL,
    [IssuedById] int  NULL,
    [IssuedBy] nvarchar(max)  NULL,
    [IssuedByPos] nvarchar(max)  NULL,
    [Date] datetime  NULL,
    [DateCreated] datetime  NULL,
    [CreatedBy] nvarchar(128)  NULL,
    [DateModified] datetime  NULL,
    [ModifiedBy] nvarchar(128)  NULL
);
GO

-- Creating table 'ICS'
CREATE TABLE [dbo].[ICS] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PRId] int  NULL,
    [Office] nvarchar(max)  NULL,
    [Issuer] nvarchar(max)  NULL,
    [IssuerPosition] nvarchar(max)  NULL,
    [Receiver] nvarchar(max)  NULL,
    [ReceiverPos] nvarchar(max)  NULL,
    [Date] datetime  NULL,
    [CreatedBy] nvarchar(128)  NULL,
    [PGSO] nvarchar(max)  NULL,
    [PGSOPos] nvarchar(max)  NULL
);
GO

-- Creating table 'ICSDetails'
CREATE TABLE [dbo].[ICSDetails] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ICSId] int  NULL,
    [ItemNo] int  NULL,
    [Quantity] decimal(19,4)  NULL,
    [Category] nvarchar(50)  NULL,
    [Item] nvarchar(max)  NULL,
    [UOM] nvarchar(50)  NULL,
    [Cost] decimal(19,4)  NULL,
    [TotalAmount] decimal(19,4)  NULL,
    [DatePurchase] datetime  NULL,
    [PropertyNumber] nvarchar(max)  NULL,
    [EstimatedUsefulLife] nvarchar(max)  NULL
);
GO

-- Creating table 'DocumentActions'
CREATE TABLE [dbo].[DocumentActions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RefId] int  NULL,
    [ProgramId] int  NULL,
    [MainActivityId] int  NULL,
    [ActivityId] int  NULL,
    [SubActivityId] int  NULL,
    [Status] nvarchar(128)  NULL,
    [ActionTaken] nvarchar(max)  NULL,
    [DateCreated] datetime  NULL,
    [ActionDate] datetime  NULL,
    [CreatedBy] nvarchar(128)  NULL,
    [TableName] nvarchar(128)  NULL,
    [Remarks] nvarchar(128)  NULL,
    [EndorsedTo] nvarchar(128)  NULL,
    [IsSend] bit  NULL,
    [isSaved] bit  NULL,
    [ControlNo] nvarchar(128)  NULL,
    [isDone] bit  NULL,
    [ActionId] int  NULL,
    [ObR_PR_No] nvarchar(128)  NULL,
    [Year] int  NULL,
    [RoutedToOfficeId] int  NULL
);
GO

-- Creating table 'Letters'
CREATE TABLE [dbo].[Letters] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RefId] int  NULL,
    [TableName] nvarchar(128)  NULL,
    [ControlNo] nvarchar(128)  NULL,
    [Template] nvarchar(128)  NULL,
    [Type] nvarchar(128)  NULL,
    [Date] datetime  NULL,
    [OfficeId] int  NULL,
    [InsideAddress] nvarchar(max)  NULL,
    [Salutation] nvarchar(10)  NULL,
    [Body] nvarchar(max)  NULL,
    [Closing] nvarchar(128)  NULL,
    [Signatories] nvarchar(128)  NULL,
    [SignatoriesPosition] nvarchar(128)  NULL,
    [CC] nvarchar(128)  NULL,
    [InTheAbsence] bit  NULL,
    [Title] nvarchar(128)  NULL,
    [CreatedBy] nvarchar(128)  NULL,
    [DateCreated] datetime  NULL
);
GO

-- Creating table 'TrashBin'
CREATE TABLE [dbo].[TrashBin] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TableName] nvarchar(50)  NULL,
    [OldValues] nvarchar(max)  NULL,
    [ParentId] int  NULL,
    [Description] nvarchar(max)  NULL,
    [DeletedBy] nvarchar(128)  NULL,
    [OfficeId] int  NULL
);
GO

-- Creating table 'ActionTakens'
CREATE TABLE [dbo].[ActionTakens] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ActionTaken] nvarchar(128)  NULL,
    [TableName] nvarchar(128)  NULL
);
GO

-- Creating table 'Files'
CREATE TABLE [dbo].[Files] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RefId] int  NULL,
    [TableName] nvarchar(50)  NULL,
    [Path] nvarchar(50)  NULL,
    [RootFolder] nvarchar(50)  NULL,
    [OriginalFileName] nvarchar(255)  NULL,
    [CreatedBy] nvarchar(128)  NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] nvarchar(128)  NOT NULL,
    [Email] nvarchar(128)  NULL,
    [EmailConfirmed] bit  NULL,
    [PasswordHash] nvarchar(max)  NULL,
    [SecurityStamp] nvarchar(max)  NULL,
    [PhoneNumber] nvarchar(25)  NULL,
    [PhoneNumberConfirmed] bit  NULL,
    [TwoFactorEnabled] bit  NULL,
    [LockoutEndDateUtc] datetime  NULL,
    [LockoutEnabled] bit  NULL,
    [AccessFailedCount] int  NULL,
    [UserName] nvarchar(50)  NULL,
    [LastUpdatedBy] nvarchar(150)  NULL,
    [LastUpdated] datetime  NULL,
    [CreatedDate] datetime  NULL,
    [FirstName] nvarchar(50)  NULL,
    [LastName] nvarchar(50)  NULL,
    [MiddleName] nvarchar(50)  NULL,
    [CivilStatus] nvarchar(12)  NULL,
    [Gender] nvarchar(6)  NULL,
    [BirthDate] datetime  NULL,
    [AddressLine2] nvarchar(500)  NULL,
    [AddressLine1] nvarchar(500)  NULL,
    [TownCity] int  NULL,
    [Cellular] nvarchar(25)  NULL,
    [Height] decimal(5,2)  NULL,
    [Weight] decimal(5,2)  NULL,
    [Religion] nvarchar(50)  NULL,
    [Citizenship] nvarchar(50)  NULL,
    [Languages] nvarchar(max)  NULL,
    [Position] nvarchar(max)  NULL,
    [OfficeId] int  NULL
);
GO

-- Creating table 'PayrollOT'
CREATE TABLE [dbo].[PayrollOT] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ObRId] int  NULL,
    [Title] nvarchar(255)  NULL,
    [Date] datetime  NULL,
    [ApprovedById] int  NULL,
    [ApprovedPosition] nvarchar(128)  NULL,
    [HeadId] int  NULL,
    [HeadPosition] nvarchar(128)  NULL,
    [CreatedBy] nvarchar(128)  NULL,
    [PAId] int  NULL,
    [PAPosition] nvarchar(128)  NULL,
    [PTId] int  NULL,
    [PTPosition] nvarchar(128)  NULL,
    [Description] nvarchar(255)  NULL
);
GO

-- Creating table 'ItenaryofTravels'
CREATE TABLE [dbo].[ItenaryofTravels] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [OBRId] int  NULL,
    [EmployeeId] int  NULL,
    [Position] nvarchar(128)  NULL,
    [OfficialAddress] nvarchar(128)  NULL,
    [Purpose] nvarchar(max)  NULL,
    [GovernorId] int  NULL,
    [PAId] int  NULL,
    [PreparedBy] int  NULL,
    [PreparedByPos] nvarchar(128)  NULL,
    [ApprovedBy] int  NULL,
    [ApprovedByPos] nvarchar(128)  NULL,
    [CreatedBy] nvarchar(128)  NULL,
    [DateCreated] datetime  NULL
);
GO

-- Creating table 'RISDetails'
CREATE TABLE [dbo].[RISDetails] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RISId] int  NULL,
    [ItemNo] int  NOT NULL,
    [Quantity] decimal(19,4)  NOT NULL,
    [Category] nvarchar(50)  NOT NULL,
    [Item] nvarchar(max)  NOT NULL,
    [UOM] nvarchar(50)  NOT NULL,
    [Cost] decimal(19,4)  NOT NULL,
    [TotalAmount] decimal(19,4)  NOT NULL
);
GO

-- Creating table 'RISHeader'
CREATE TABLE [dbo].[RISHeader] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PRId] int  NULL,
    [OfficeId] int  NULL,
    [RISNo] nvarchar(50)  NULL,
    [SAI] nvarchar(50)  NULL,
    [RISDate] datetime  NULL,
    [SAIDate] datetime  NULL,
    [CreatedBy] nvarchar(128)  NULL,
    [RequestedBy] nvarchar(128)  NULL,
    [RequestedByPos] nvarchar(128)  NULL,
    [ApprovedBy] nvarchar(128)  NULL,
    [ApprovedByPos] nvarchar(128)  NULL,
    [IssuedBy] nvarchar(128)  NULL,
    [IssuedByPos] nvarchar(128)  NULL,
    [ReceivedBy] nvarchar(128)  NULL,
    [ReceivedByPos] nvarchar(128)  NULL,
    [Date] datetime  NULL,
    [Purpose] nvarchar(max)  NULL
);
GO

-- Creating table 'ItenaryDetails'
CREATE TABLE [dbo].[ItenaryDetails] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IOTId] int  NULL,
    [Date] datetime  NULL,
    [PlaceVisited] nvarchar(max)  NULL,
    [DepartureTime] datetime  NULL,
    [ArrivalTime] datetime  NULL,
    [MeansOfTransportation] nvarchar(128)  NULL,
    [TransportationFee] decimal(19,4)  NULL,
    [PerDiems] decimal(19,4)  NULL,
    [DailyAllowance] decimal(19,4)  NULL,
    [TotalAmount] decimal(19,4)  NULL,
    [DateCreated] datetime  NULL,
    [CreatedBy] nvarchar(128)  NULL,
    [InclusiveTime] nvarchar(128)  NULL
);
GO

-- Creating table 'PayrollOTDetails'
CREATE TABLE [dbo].[PayrollOTDetails] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ItemNo] int  NULL,
    [PayrollOTId] int  NULL,
    [EmployeeId] int  NULL,
    [RatePerMonth] decimal(19,4)  NULL,
    [RatePerDay] decimal(19,4)  NULL,
    [RatePerHr] decimal(19,4)  NULL,
    [WeekEndNoHrs] decimal(19,4)  NULL,
    [WeekDayNoHrs] decimal(19,4)  NULL,
    [SubTotal] decimal(19,4)  NULL,
    [UnderPay] decimal(19,4)  NULL,
    [TotalAmount] decimal(19,4)  NULL,
    [DateCreated] datetime  NULL
);
GO

-- Creating table 'EmployeesInPayee'
CREATE TABLE [dbo].[EmployeesInPayee] (
    [Employees_Id] int  NOT NULL,
    [Payees_Id] int  NOT NULL
);
GO

-- Creating table 'UserRolesInFunctions'
CREATE TABLE [dbo].[UserRolesInFunctions] (
    [Functions_Id] int  NOT NULL,
    [UserRoles_Id] nvarchar(128)  NOT NULL
);
GO

-- Creating table 'BACInAOQ'
CREATE TABLE [dbo].[BACInAOQ] (
    [BACMembers_Id] int  NOT NULL,
    [BacMembers_Id] int  NOT NULL
);
GO

-- Creating table 'OBRInLetters'
CREATE TABLE [dbo].[OBRInLetters] (
    [Letters_Id] int  NOT NULL,
    [Obligations_Id] int  NOT NULL
);
GO

-- Creating table 'UsersInDocumentActions'
CREATE TABLE [dbo].[UsersInDocumentActions] (
    [RoutedDocuments_Id] int  NOT NULL,
    [RoutedToUsers_Id] nvarchar(128)  NOT NULL
);
GO

-- Creating table 'UsersInRoles'
CREATE TABLE [dbo].[UsersInRoles] (
    [UserRoles_Id] nvarchar(128)  NOT NULL,
    [Users_Id] nvarchar(128)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Allotments'
ALTER TABLE [dbo].[Allotments]
ADD CONSTRAINT [PK_Allotments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Appropriations'
ALTER TABLE [dbo].[Appropriations]
ADD CONSTRAINT [PK_Appropriations]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [PK_Categories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DefaultAccounts'
ALTER TABLE [dbo].[DefaultAccounts]
ADD CONSTRAINT [PK_DefaultAccounts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DefaultSettings'
ALTER TABLE [dbo].[DefaultSettings]
ADD CONSTRAINT [PK_DefaultSettings]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [PK_Employees]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Functions'
ALTER TABLE [dbo].[Functions]
ADD CONSTRAINT [PK_Functions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FundTypes'
ALTER TABLE [dbo].[FundTypes]
ADD CONSTRAINT [PK_FundTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Items'
ALTER TABLE [dbo].[Items]
ADD CONSTRAINT [PK_Items]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Logs'
ALTER TABLE [dbo].[Logs]
ADD CONSTRAINT [PK_Logs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Obligations'
ALTER TABLE [dbo].[Obligations]
ADD CONSTRAINT [PK_Obligations]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Offices'
ALTER TABLE [dbo].[Offices]
ADD CONSTRAINT [PK_Offices]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Payees'
ALTER TABLE [dbo].[Payees]
ADD CONSTRAINT [PK_Payees]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PayrollDetails'
ALTER TABLE [dbo].[PayrollDetails]
ADD CONSTRAINT [PK_PayrollDetails]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Positions'
ALTER TABLE [dbo].[Positions]
ADD CONSTRAINT [PK_Positions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PRDetails'
ALTER TABLE [dbo].[PRDetails]
ADD CONSTRAINT [PK_PRDetails]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PriceQuotations'
ALTER TABLE [dbo].[PriceQuotations]
ADD CONSTRAINT [PK_PriceQuotations]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Provinces'
ALTER TABLE [dbo].[Provinces]
ADD CONSTRAINT [PK_Provinces]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PurchaseOrders'
ALTER TABLE [dbo].[PurchaseOrders]
ADD CONSTRAINT [PK_PurchaseOrders]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ReAlignments'
ALTER TABLE [dbo].[ReAlignments]
ADD CONSTRAINT [PK_ReAlignments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Signatories'
ALTER TABLE [dbo].[Signatories]
ADD CONSTRAINT [PK_Signatories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Suppliers'
ALTER TABLE [dbo].[Suppliers]
ADD CONSTRAINT [PK_Suppliers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Towns'
ALTER TABLE [dbo].[Towns]
ADD CONSTRAINT [PK_Towns]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UserClaims'
ALTER TABLE [dbo].[UserClaims]
ADD CONSTRAINT [PK_UserClaims]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [LoginProvider], [ProviderKey], [UserId] in table 'UserLogins'
ALTER TABLE [dbo].[UserLogins]
ADD CONSTRAINT [PK_UserLogins]
    PRIMARY KEY CLUSTERED ([LoginProvider], [ProviderKey], [UserId] ASC);
GO

-- Creating primary key on [Id] in table 'UserRoles'
ALTER TABLE [dbo].[UserRoles]
ADD CONSTRAINT [PK_UserRoles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Years'
ALTER TABLE [dbo].[Years]
ADD CONSTRAINT [PK_Years]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Payrolls'
ALTER TABLE [dbo].[Payrolls]
ADD CONSTRAINT [PK_Payrolls]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PayrollWages'
ALTER TABLE [dbo].[PayrollWages]
ADD CONSTRAINT [PK_PayrollWages]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BACMembers'
ALTER TABLE [dbo].[BACMembers]
ADD CONSTRAINT [PK_BACMembers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AllotmentLetter'
ALTER TABLE [dbo].[AllotmentLetter]
ADD CONSTRAINT [PK_AllotmentLetter]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ControlNumbers'
ALTER TABLE [dbo].[ControlNumbers]
ADD CONSTRAINT [PK_ControlNumbers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PayrollWageDetails'
ALTER TABLE [dbo].[PayrollWageDetails]
ADD CONSTRAINT [PK_PayrollWageDetails]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Templates'
ALTER TABLE [dbo].[Templates]
ADD CONSTRAINT [PK_Templates]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SalarySchedules'
ALTER TABLE [dbo].[SalarySchedules]
ADD CONSTRAINT [PK_SalarySchedules]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PayrollDifferentials'
ALTER TABLE [dbo].[PayrollDifferentials]
ADD CONSTRAINT [PK_PayrollDifferentials]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ORDetails'
ALTER TABLE [dbo].[ORDetails]
ADD CONSTRAINT [PK_ORDetails]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PODetails'
ALTER TABLE [dbo].[PODetails]
ADD CONSTRAINT [PK_PODetails]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PQDetails'
ALTER TABLE [dbo].[PQDetails]
ADD CONSTRAINT [PK_PQDetails]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AOQ'
ALTER TABLE [dbo].[AOQ]
ADD CONSTRAINT [PK_AOQ]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AOQDetails'
ALTER TABLE [dbo].[AOQDetails]
ADD CONSTRAINT [PK_AOQDetails]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'APRs'
ALTER TABLE [dbo].[APRs]
ADD CONSTRAINT [PK_APRs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'APRDetails'
ALTER TABLE [dbo].[APRDetails]
ADD CONSTRAINT [PK_APRDetails]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Actions'
ALTER TABLE [dbo].[Actions]
ADD CONSTRAINT [PK_Actions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PayrollDifferentialDetails'
ALTER TABLE [dbo].[PayrollDifferentialDetails]
ADD CONSTRAINT [PK_PayrollDifferentialDetails]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AIRDetails'
ALTER TABLE [dbo].[AIRDetails]
ADD CONSTRAINT [PK_AIRDetails]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PIS'
ALTER TABLE [dbo].[PIS]
ADD CONSTRAINT [PK_PIS]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PISDetails'
ALTER TABLE [dbo].[PISDetails]
ADD CONSTRAINT [PK_PISDetails]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AIReports'
ALTER TABLE [dbo].[AIReports]
ADD CONSTRAINT [PK_AIReports]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PurchaseRequests'
ALTER TABLE [dbo].[PurchaseRequests]
ADD CONSTRAINT [PK_PurchaseRequests]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Liquidations'
ALTER TABLE [dbo].[Liquidations]
ADD CONSTRAINT [PK_Liquidations]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PARDetails'
ALTER TABLE [dbo].[PARDetails]
ADD CONSTRAINT [PK_PARDetails]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PAR'
ALTER TABLE [dbo].[PAR]
ADD CONSTRAINT [PK_PAR]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ICS'
ALTER TABLE [dbo].[ICS]
ADD CONSTRAINT [PK_ICS]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ICSDetails'
ALTER TABLE [dbo].[ICSDetails]
ADD CONSTRAINT [PK_ICSDetails]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DocumentActions'
ALTER TABLE [dbo].[DocumentActions]
ADD CONSTRAINT [PK_DocumentActions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Letters'
ALTER TABLE [dbo].[Letters]
ADD CONSTRAINT [PK_Letters]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TrashBin'
ALTER TABLE [dbo].[TrashBin]
ADD CONSTRAINT [PK_TrashBin]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ActionTakens'
ALTER TABLE [dbo].[ActionTakens]
ADD CONSTRAINT [PK_ActionTakens]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Files'
ALTER TABLE [dbo].[Files]
ADD CONSTRAINT [PK_Files]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PayrollOT'
ALTER TABLE [dbo].[PayrollOT]
ADD CONSTRAINT [PK_PayrollOT]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ItenaryofTravels'
ALTER TABLE [dbo].[ItenaryofTravels]
ADD CONSTRAINT [PK_ItenaryofTravels]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RISDetails'
ALTER TABLE [dbo].[RISDetails]
ADD CONSTRAINT [PK_RISDetails]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RISHeader'
ALTER TABLE [dbo].[RISHeader]
ADD CONSTRAINT [PK_RISHeader]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ItenaryDetails'
ALTER TABLE [dbo].[ItenaryDetails]
ADD CONSTRAINT [PK_ItenaryDetails]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PayrollOTDetails'
ALTER TABLE [dbo].[PayrollOTDetails]
ADD CONSTRAINT [PK_PayrollOTDetails]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Employees_Id], [Payees_Id] in table 'EmployeesInPayee'
ALTER TABLE [dbo].[EmployeesInPayee]
ADD CONSTRAINT [PK_EmployeesInPayee]
    PRIMARY KEY CLUSTERED ([Employees_Id], [Payees_Id] ASC);
GO

-- Creating primary key on [Functions_Id], [UserRoles_Id] in table 'UserRolesInFunctions'
ALTER TABLE [dbo].[UserRolesInFunctions]
ADD CONSTRAINT [PK_UserRolesInFunctions]
    PRIMARY KEY CLUSTERED ([Functions_Id], [UserRoles_Id] ASC);
GO

-- Creating primary key on [BACMembers_Id], [BacMembers_Id] in table 'BACInAOQ'
ALTER TABLE [dbo].[BACInAOQ]
ADD CONSTRAINT [PK_BACInAOQ]
    PRIMARY KEY CLUSTERED ([BACMembers_Id], [BacMembers_Id] ASC);
GO

-- Creating primary key on [Letters_Id], [Obligations_Id] in table 'OBRInLetters'
ALTER TABLE [dbo].[OBRInLetters]
ADD CONSTRAINT [PK_OBRInLetters]
    PRIMARY KEY CLUSTERED ([Letters_Id], [Obligations_Id] ASC);
GO

-- Creating primary key on [RoutedDocuments_Id], [RoutedToUsers_Id] in table 'UsersInDocumentActions'
ALTER TABLE [dbo].[UsersInDocumentActions]
ADD CONSTRAINT [PK_UsersInDocumentActions]
    PRIMARY KEY CLUSTERED ([RoutedDocuments_Id], [RoutedToUsers_Id] ASC);
GO

-- Creating primary key on [UserRoles_Id], [Users_Id] in table 'UsersInRoles'
ALTER TABLE [dbo].[UsersInRoles]
ADD CONSTRAINT [PK_UsersInRoles]
    PRIMARY KEY CLUSTERED ([UserRoles_Id], [Users_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [AppropriationId] in table 'Allotments'
ALTER TABLE [dbo].[Allotments]
ADD CONSTRAINT [FK_Allotments_Appropriations]
    FOREIGN KEY ([AppropriationId])
    REFERENCES [dbo].[Appropriations]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Allotments_Appropriations'
CREATE INDEX [IX_FK_Allotments_Appropriations]
ON [dbo].[Allotments]
    ([AppropriationId]);
GO

-- Creating foreign key on [FundTypeId] in table 'Appropriations'
ALTER TABLE [dbo].[Appropriations]
ADD CONSTRAINT [FK_Appropriations_FundTypes]
    FOREIGN KEY ([FundTypeId])
    REFERENCES [dbo].[FundTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Appropriations_FundTypes'
CREATE INDEX [IX_FK_Appropriations_FundTypes]
ON [dbo].[Appropriations]
    ([FundTypeId]);
GO

-- Creating foreign key on [SourceAppropriationId] in table 'ReAlignments'
ALTER TABLE [dbo].[ReAlignments]
ADD CONSTRAINT [FK_ReAlignments_Appropriations]
    FOREIGN KEY ([SourceAppropriationId])
    REFERENCES [dbo].[Appropriations]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ReAlignments_Appropriations'
CREATE INDEX [IX_FK_ReAlignments_Appropriations]
ON [dbo].[ReAlignments]
    ([SourceAppropriationId]);
GO

-- Creating foreign key on [TargetAppropriationId] in table 'ReAlignments'
ALTER TABLE [dbo].[ReAlignments]
ADD CONSTRAINT [FK_ReAlignments_TargetSource]
    FOREIGN KEY ([TargetAppropriationId])
    REFERENCES [dbo].[Appropriations]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ReAlignments_TargetSource'
CREATE INDEX [IX_FK_ReAlignments_TargetSource]
ON [dbo].[ReAlignments]
    ([TargetAppropriationId]);
GO

-- Creating foreign key on [FundTypeId] in table 'DefaultAccounts'
ALTER TABLE [dbo].[DefaultAccounts]
ADD CONSTRAINT [FK_DefaultAccounts_FundTypes]
    FOREIGN KEY ([FundTypeId])
    REFERENCES [dbo].[FundTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DefaultAccounts_FundTypes'
CREATE INDEX [IX_FK_DefaultAccounts_FundTypes]
ON [dbo].[DefaultAccounts]
    ([FundTypeId]);
GO

-- Creating foreign key on [EmployeeId] in table 'PayrollDetails'
ALTER TABLE [dbo].[PayrollDetails]
ADD CONSTRAINT [FK_PayrollDetails_Employees]
    FOREIGN KEY ([EmployeeId])
    REFERENCES [dbo].[Employees]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PayrollDetails_Employees'
CREATE INDEX [IX_FK_PayrollDetails_Employees]
ON [dbo].[PayrollDetails]
    ([EmployeeId]);
GO

-- Creating foreign key on [OfficeId] in table 'Obligations'
ALTER TABLE [dbo].[Obligations]
ADD CONSTRAINT [FK_Obligations_Offices]
    FOREIGN KEY ([OfficeId])
    REFERENCES [dbo].[Offices]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Obligations_Offices'
CREATE INDEX [IX_FK_Obligations_Offices]
ON [dbo].[Obligations]
    ([OfficeId]);
GO

-- Creating foreign key on [PayeeId] in table 'Obligations'
ALTER TABLE [dbo].[Obligations]
ADD CONSTRAINT [FK_Obligations_Payees]
    FOREIGN KEY ([PayeeId])
    REFERENCES [dbo].[Payees]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Obligations_Payees'
CREATE INDEX [IX_FK_Obligations_Payees]
ON [dbo].[Obligations]
    ([PayeeId]);
GO

-- Creating foreign key on [UnderOf] in table 'Offices'
ALTER TABLE [dbo].[Offices]
ADD CONSTRAINT [FK_Offices_Offices]
    FOREIGN KEY ([UnderOf])
    REFERENCES [dbo].[Offices]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Offices_Offices'
CREATE INDEX [IX_FK_Offices_Offices]
ON [dbo].[Offices]
    ([UnderOf]);
GO

-- Creating foreign key on [OfficeId] in table 'Payees'
ALTER TABLE [dbo].[Payees]
ADD CONSTRAINT [FK_Payees_Offices]
    FOREIGN KEY ([OfficeId])
    REFERENCES [dbo].[Offices]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Payees_Offices'
CREATE INDEX [IX_FK_Payees_Offices]
ON [dbo].[Payees]
    ([OfficeId]);
GO

-- Creating foreign key on [ProvinceId] in table 'Towns'
ALTER TABLE [dbo].[Towns]
ADD CONSTRAINT [FK_Towns_Towns]
    FOREIGN KEY ([ProvinceId])
    REFERENCES [dbo].[Provinces]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Towns_Towns'
CREATE INDEX [IX_FK_Towns_Towns]
ON [dbo].[Towns]
    ([ProvinceId]);
GO

-- Creating foreign key on [Employees_Id] in table 'EmployeesInPayee'
ALTER TABLE [dbo].[EmployeesInPayee]
ADD CONSTRAINT [FK_EmployeesInPayee_Employees]
    FOREIGN KEY ([Employees_Id])
    REFERENCES [dbo].[Employees]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Payees_Id] in table 'EmployeesInPayee'
ALTER TABLE [dbo].[EmployeesInPayee]
ADD CONSTRAINT [FK_EmployeesInPayee_Payees]
    FOREIGN KEY ([Payees_Id])
    REFERENCES [dbo].[Payees]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeesInPayee_Payees'
CREATE INDEX [IX_FK_EmployeesInPayee_Payees]
ON [dbo].[EmployeesInPayee]
    ([Payees_Id]);
GO

-- Creating foreign key on [Functions_Id] in table 'UserRolesInFunctions'
ALTER TABLE [dbo].[UserRolesInFunctions]
ADD CONSTRAINT [FK_UserRolesInFunctions_Functions]
    FOREIGN KEY ([Functions_Id])
    REFERENCES [dbo].[Functions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [UserRoles_Id] in table 'UserRolesInFunctions'
ALTER TABLE [dbo].[UserRolesInFunctions]
ADD CONSTRAINT [FK_UserRolesInFunctions_UserRoles]
    FOREIGN KEY ([UserRoles_Id])
    REFERENCES [dbo].[UserRoles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserRolesInFunctions_UserRoles'
CREATE INDEX [IX_FK_UserRolesInFunctions_UserRoles]
ON [dbo].[UserRolesInFunctions]
    ([UserRoles_Id]);
GO

-- Creating foreign key on [Id] in table 'Payrolls'
ALTER TABLE [dbo].[Payrolls]
ADD CONSTRAINT [FK_Payrolls_Obligations]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Obligations]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [PayrollId] in table 'PayrollDetails'
ALTER TABLE [dbo].[PayrollDetails]
ADD CONSTRAINT [FK_PayrollDetails_Payrolls]
    FOREIGN KEY ([PayrollId])
    REFERENCES [dbo].[Payrolls]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PayrollDetails_Payrolls'
CREATE INDEX [IX_FK_PayrollDetails_Payrolls]
ON [dbo].[PayrollDetails]
    ([PayrollId]);
GO

-- Creating foreign key on [Id] in table 'PayrollWages'
ALTER TABLE [dbo].[PayrollWages]
ADD CONSTRAINT [FK_PayrollWage_Obligations]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Obligations]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ItemId] in table 'PRDetails'
ALTER TABLE [dbo].[PRDetails]
ADD CONSTRAINT [FK_PRDetails_Items]
    FOREIGN KEY ([ItemId])
    REFERENCES [dbo].[Items]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PRDetails_Items'
CREATE INDEX [IX_FK_PRDetails_Items]
ON [dbo].[PRDetails]
    ([ItemId]);
GO

-- Creating foreign key on [EmployeeId] in table 'BACMembers'
ALTER TABLE [dbo].[BACMembers]
ADD CONSTRAINT [FK_BACMembers_Employees]
    FOREIGN KEY ([EmployeeId])
    REFERENCES [dbo].[Employees]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BACMembers_Employees'
CREATE INDEX [IX_FK_BACMembers_Employees]
ON [dbo].[BACMembers]
    ([EmployeeId]);
GO

-- Creating foreign key on [OfficeId] in table 'BACMembers'
ALTER TABLE [dbo].[BACMembers]
ADD CONSTRAINT [FK_BACMembers_Offices]
    FOREIGN KEY ([OfficeId])
    REFERENCES [dbo].[Offices]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BACMembers_Offices'
CREATE INDEX [IX_FK_BACMembers_Offices]
ON [dbo].[BACMembers]
    ([OfficeId]);
GO

-- Creating foreign key on [AppropriationId] in table 'AllotmentLetter'
ALTER TABLE [dbo].[AllotmentLetter]
ADD CONSTRAINT [FK_AllotmentLetter_Appropriations]
    FOREIGN KEY ([AppropriationId])
    REFERENCES [dbo].[Appropriations]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AllotmentLetter_Appropriations'
CREATE INDEX [IX_FK_AllotmentLetter_Appropriations]
ON [dbo].[AllotmentLetter]
    ([AppropriationId]);
GO

-- Creating foreign key on [OfficeId] in table 'ControlNumbers'
ALTER TABLE [dbo].[ControlNumbers]
ADD CONSTRAINT [FK_ControlNumbers_Offices]
    FOREIGN KEY ([OfficeId])
    REFERENCES [dbo].[Offices]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ControlNumbers_Offices'
CREATE INDEX [IX_FK_ControlNumbers_Offices]
ON [dbo].[ControlNumbers]
    ([OfficeId]);
GO

-- Creating foreign key on [EmployeeId] in table 'PayrollWageDetails'
ALTER TABLE [dbo].[PayrollWageDetails]
ADD CONSTRAINT [FK_PayrollWages_Employees]
    FOREIGN KEY ([EmployeeId])
    REFERENCES [dbo].[Employees]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PayrollWages_Employees'
CREATE INDEX [IX_FK_PayrollWages_Employees]
ON [dbo].[PayrollWageDetails]
    ([EmployeeId]);
GO

-- Creating foreign key on [PayrollWageId] in table 'PayrollWageDetails'
ALTER TABLE [dbo].[PayrollWageDetails]
ADD CONSTRAINT [FK_PayrollWageDetails_PayrollWages]
    FOREIGN KEY ([PayrollWageId])
    REFERENCES [dbo].[PayrollWages]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PayrollWageDetails_PayrollWages'
CREATE INDEX [IX_FK_PayrollWageDetails_PayrollWages]
ON [dbo].[PayrollWageDetails]
    ([PayrollWageId]);
GO

-- Creating foreign key on [AppropriationId] in table 'ORDetails'
ALTER TABLE [dbo].[ORDetails]
ADD CONSTRAINT [FK_ORDetails_Appropriations]
    FOREIGN KEY ([AppropriationId])
    REFERENCES [dbo].[Appropriations]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ORDetails_Appropriations'
CREATE INDEX [IX_FK_ORDetails_Appropriations]
ON [dbo].[ORDetails]
    ([AppropriationId]);
GO

-- Creating foreign key on [ObligationId] in table 'ORDetails'
ALTER TABLE [dbo].[ORDetails]
ADD CONSTRAINT [FK_ORDetails_Obligations]
    FOREIGN KEY ([ObligationId])
    REFERENCES [dbo].[Obligations]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ORDetails_Obligations'
CREATE INDEX [IX_FK_ORDetails_Obligations]
ON [dbo].[ORDetails]
    ([ObligationId]);
GO

-- Creating foreign key on [ObId] in table 'PayrollDifferentials'
ALTER TABLE [dbo].[PayrollDifferentials]
ADD CONSTRAINT [FK_PayrollDifferentials_Obligations]
    FOREIGN KEY ([ObId])
    REFERENCES [dbo].[Obligations]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PayrollDifferentials_Obligations'
CREATE INDEX [IX_FK_PayrollDifferentials_Obligations]
ON [dbo].[PayrollDifferentials]
    ([ObId]);
GO

-- Creating foreign key on [POId] in table 'PODetails'
ALTER TABLE [dbo].[PODetails]
ADD CONSTRAINT [FK_PODetails_PurchaseOrders]
    FOREIGN KEY ([POId])
    REFERENCES [dbo].[PurchaseOrders]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PODetails_PurchaseOrders'
CREATE INDEX [IX_FK_PODetails_PurchaseOrders]
ON [dbo].[PODetails]
    ([POId]);
GO

-- Creating foreign key on [PQId] in table 'PQDetails'
ALTER TABLE [dbo].[PQDetails]
ADD CONSTRAINT [FK_PQDetails_PurchaseQuotations]
    FOREIGN KEY ([PQId])
    REFERENCES [dbo].[PriceQuotations]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PQDetails_PurchaseQuotations'
CREATE INDEX [IX_FK_PQDetails_PurchaseQuotations]
ON [dbo].[PQDetails]
    ([PQId]);
GO

-- Creating foreign key on [BACMembers_Id] in table 'BACInAOQ'
ALTER TABLE [dbo].[BACInAOQ]
ADD CONSTRAINT [FK_BACInAOQ_AOQ]
    FOREIGN KEY ([BACMembers_Id])
    REFERENCES [dbo].[AOQ]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [BacMembers_Id] in table 'BACInAOQ'
ALTER TABLE [dbo].[BACInAOQ]
ADD CONSTRAINT [FK_BACInAOQ_Signatories]
    FOREIGN KEY ([BacMembers_Id])
    REFERENCES [dbo].[Signatories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BACInAOQ_Signatories'
CREATE INDEX [IX_FK_BACInAOQ_Signatories]
ON [dbo].[BACInAOQ]
    ([BacMembers_Id]);
GO

-- Creating foreign key on [AOQId] in table 'AOQDetails'
ALTER TABLE [dbo].[AOQDetails]
ADD CONSTRAINT [FK_AOQDetails_AOQ]
    FOREIGN KEY ([AOQId])
    REFERENCES [dbo].[AOQ]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AOQDetails_AOQ'
CREATE INDEX [IX_FK_AOQDetails_AOQ]
ON [dbo].[AOQDetails]
    ([AOQId]);
GO

-- Creating foreign key on [BACChairperson] in table 'AOQ'
ALTER TABLE [dbo].[AOQ]
ADD CONSTRAINT [FK_AOQ_Signatories]
    FOREIGN KEY ([BACChairperson])
    REFERENCES [dbo].[Signatories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AOQ_Signatories'
CREATE INDEX [IX_FK_AOQ_Signatories]
ON [dbo].[AOQ]
    ([BACChairperson]);
GO

-- Creating foreign key on [OfficeId] in table 'AOQ'
ALTER TABLE [dbo].[AOQ]
ADD CONSTRAINT [FK_AOQ_Offices]
    FOREIGN KEY ([OfficeId])
    REFERENCES [dbo].[Offices]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AOQ_Offices'
CREATE INDEX [IX_FK_AOQ_Offices]
ON [dbo].[AOQ]
    ([OfficeId]);
GO

-- Creating foreign key on [APRId] in table 'APRDetails'
ALTER TABLE [dbo].[APRDetails]
ADD CONSTRAINT [FK_APRDetails_APRs]
    FOREIGN KEY ([APRId])
    REFERENCES [dbo].[APRs]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_APRDetails_APRs'
CREATE INDEX [IX_FK_APRDetails_APRs]
ON [dbo].[APRDetails]
    ([APRId]);
GO

-- Creating foreign key on [ParentId] in table 'Actions'
ALTER TABLE [dbo].[Actions]
ADD CONSTRAINT [FK_Actions_Actions]
    FOREIGN KEY ([ParentId])
    REFERENCES [dbo].[Actions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Actions_Actions'
CREATE INDEX [IX_FK_Actions_Actions]
ON [dbo].[Actions]
    ([ParentId]);
GO

-- Creating foreign key on [EmployeeId] in table 'PayrollDifferentialDetails'
ALTER TABLE [dbo].[PayrollDifferentialDetails]
ADD CONSTRAINT [FK_PayrollDifferentialDetails_Employees]
    FOREIGN KEY ([EmployeeId])
    REFERENCES [dbo].[Employees]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PayrollDifferentialDetails_Employees'
CREATE INDEX [IX_FK_PayrollDifferentialDetails_Employees]
ON [dbo].[PayrollDifferentialDetails]
    ([EmployeeId]);
GO

-- Creating foreign key on [PayrollDiffentialId] in table 'PayrollDifferentialDetails'
ALTER TABLE [dbo].[PayrollDifferentialDetails]
ADD CONSTRAINT [FK_PayrollDifferentialDetails_PayrollDifferentials]
    FOREIGN KEY ([PayrollDiffentialId])
    REFERENCES [dbo].[PayrollDifferentials]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PayrollDifferentialDetails_PayrollDifferentials'
CREATE INDEX [IX_FK_PayrollDifferentialDetails_PayrollDifferentials]
ON [dbo].[PayrollDifferentialDetails]
    ([PayrollDiffentialId]);
GO

-- Creating foreign key on [PISId] in table 'PISDetails'
ALTER TABLE [dbo].[PISDetails]
ADD CONSTRAINT [FK_PISDetails_PIS]
    FOREIGN KEY ([PISId])
    REFERENCES [dbo].[PIS]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PISDetails_PIS'
CREATE INDEX [IX_FK_PISDetails_PIS]
ON [dbo].[PISDetails]
    ([PISId]);
GO

-- Creating foreign key on [AIReportId] in table 'AIRDetails'
ALTER TABLE [dbo].[AIRDetails]
ADD CONSTRAINT [FK_AIRDetails_AIReports]
    FOREIGN KEY ([AIReportId])
    REFERENCES [dbo].[AIReports]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AIRDetails_AIReports'
CREATE INDEX [IX_FK_AIRDetails_AIReports]
ON [dbo].[AIRDetails]
    ([AIReportId]);
GO

-- Creating foreign key on [PRId] in table 'AIReports'
ALTER TABLE [dbo].[AIReports]
ADD CONSTRAINT [FK_AIReports_PurchaseRequests]
    FOREIGN KEY ([PRId])
    REFERENCES [dbo].[PurchaseRequests]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AIReports_PurchaseRequests'
CREATE INDEX [IX_FK_AIReports_PurchaseRequests]
ON [dbo].[AIReports]
    ([PRId]);
GO

-- Creating foreign key on [PRId] in table 'AllotmentLetter'
ALTER TABLE [dbo].[AllotmentLetter]
ADD CONSTRAINT [FK_AllotmentLetter_PurchaseRequests]
    FOREIGN KEY ([PRId])
    REFERENCES [dbo].[PurchaseRequests]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AllotmentLetter_PurchaseRequests'
CREATE INDEX [IX_FK_AllotmentLetter_PurchaseRequests]
ON [dbo].[AllotmentLetter]
    ([PRId]);
GO

-- Creating foreign key on [PRId] in table 'AOQ'
ALTER TABLE [dbo].[AOQ]
ADD CONSTRAINT [FK_AOQ_PurchaseRequests]
    FOREIGN KEY ([PRId])
    REFERENCES [dbo].[PurchaseRequests]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AOQ_PurchaseRequests'
CREATE INDEX [IX_FK_AOQ_PurchaseRequests]
ON [dbo].[AOQ]
    ([PRId]);
GO

-- Creating foreign key on [AppropriationId] in table 'PurchaseRequests'
ALTER TABLE [dbo].[PurchaseRequests]
ADD CONSTRAINT [FK_PurchaseRequests_Appropriations]
    FOREIGN KEY ([AppropriationId])
    REFERENCES [dbo].[Appropriations]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PurchaseRequests_Appropriations'
CREATE INDEX [IX_FK_PurchaseRequests_Appropriations]
ON [dbo].[PurchaseRequests]
    ([AppropriationId]);
GO

-- Creating foreign key on [PRId] in table 'APRs'
ALTER TABLE [dbo].[APRs]
ADD CONSTRAINT [FK_APRs_PurchaseRequests]
    FOREIGN KEY ([PRId])
    REFERENCES [dbo].[PurchaseRequests]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_APRs_PurchaseRequests'
CREATE INDEX [IX_FK_APRs_PurchaseRequests]
ON [dbo].[APRs]
    ([PRId]);
GO

-- Creating foreign key on [PRNo] in table 'Obligations'
ALTER TABLE [dbo].[Obligations]
ADD CONSTRAINT [FK_Obligations_PurchaseRequests]
    FOREIGN KEY ([PRNo])
    REFERENCES [dbo].[PurchaseRequests]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Obligations_PurchaseRequests'
CREATE INDEX [IX_FK_Obligations_PurchaseRequests]
ON [dbo].[Obligations]
    ([PRNo]);
GO

-- Creating foreign key on [OfficeId] in table 'PurchaseRequests'
ALTER TABLE [dbo].[PurchaseRequests]
ADD CONSTRAINT [FK_PurchaseRequests_Offices]
    FOREIGN KEY ([OfficeId])
    REFERENCES [dbo].[Offices]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PurchaseRequests_Offices'
CREATE INDEX [IX_FK_PurchaseRequests_Offices]
ON [dbo].[PurchaseRequests]
    ([OfficeId]);
GO

-- Creating foreign key on [PRId] in table 'PIS'
ALTER TABLE [dbo].[PIS]
ADD CONSTRAINT [FK_PIS_PurchaseRequests]
    FOREIGN KEY ([PRId])
    REFERENCES [dbo].[PurchaseRequests]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PIS_PurchaseRequests'
CREATE INDEX [IX_FK_PIS_PurchaseRequests]
ON [dbo].[PIS]
    ([PRId]);
GO

-- Creating foreign key on [PRId] in table 'PRDetails'
ALTER TABLE [dbo].[PRDetails]
ADD CONSTRAINT [FK_PRDetails_PurchaseRequests]
    FOREIGN KEY ([PRId])
    REFERENCES [dbo].[PurchaseRequests]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PRDetails_PurchaseRequests'
CREATE INDEX [IX_FK_PRDetails_PurchaseRequests]
ON [dbo].[PRDetails]
    ([PRId]);
GO

-- Creating foreign key on [PRId] in table 'PriceQuotations'
ALTER TABLE [dbo].[PriceQuotations]
ADD CONSTRAINT [FK_PurchaseQuotations_PurchaseRequests]
    FOREIGN KEY ([PRId])
    REFERENCES [dbo].[PurchaseRequests]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PurchaseQuotations_PurchaseRequests'
CREATE INDEX [IX_FK_PurchaseQuotations_PurchaseRequests]
ON [dbo].[PriceQuotations]
    ([PRId]);
GO

-- Creating foreign key on [PRId] in table 'PurchaseOrders'
ALTER TABLE [dbo].[PurchaseOrders]
ADD CONSTRAINT [FK_PurchaseOrders_PurchaseRequests]
    FOREIGN KEY ([PRId])
    REFERENCES [dbo].[PurchaseRequests]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PurchaseOrders_PurchaseRequests'
CREATE INDEX [IX_FK_PurchaseOrders_PurchaseRequests]
ON [dbo].[PurchaseOrders]
    ([PRId]);
GO

-- Creating foreign key on [POId] in table 'Obligations'
ALTER TABLE [dbo].[Obligations]
ADD CONSTRAINT [FK_Obligations_PurchaseOrders]
    FOREIGN KEY ([POId])
    REFERENCES [dbo].[PurchaseOrders]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Obligations_PurchaseOrders'
CREATE INDEX [IX_FK_Obligations_PurchaseOrders]
ON [dbo].[Obligations]
    ([POId]);
GO

-- Creating foreign key on [ObRId] in table 'Liquidations'
ALTER TABLE [dbo].[Liquidations]
ADD CONSTRAINT [FK_Liquidations_Obligations]
    FOREIGN KEY ([ObRId])
    REFERENCES [dbo].[Obligations]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Liquidations_Obligations'
CREATE INDEX [IX_FK_Liquidations_Obligations]
ON [dbo].[Liquidations]
    ([ObRId]);
GO

-- Creating foreign key on [PayeeId] in table 'Liquidations'
ALTER TABLE [dbo].[Liquidations]
ADD CONSTRAINT [FK_Liquidations_Payees]
    FOREIGN KEY ([PayeeId])
    REFERENCES [dbo].[Payees]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Liquidations_Payees'
CREATE INDEX [IX_FK_Liquidations_Payees]
ON [dbo].[Liquidations]
    ([PayeeId]);
GO

-- Creating foreign key on [PAId] in table 'Liquidations'
ALTER TABLE [dbo].[Liquidations]
ADD CONSTRAINT [FK_Liquidations_Accountant]
    FOREIGN KEY ([PAId])
    REFERENCES [dbo].[Signatories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Liquidations_Accountant'
CREATE INDEX [IX_FK_Liquidations_Accountant]
ON [dbo].[Liquidations]
    ([PAId]);
GO

-- Creating foreign key on [HeadOfDep] in table 'Liquidations'
ALTER TABLE [dbo].[Liquidations]
ADD CONSTRAINT [FK_Liquidations_Head]
    FOREIGN KEY ([HeadOfDep])
    REFERENCES [dbo].[Signatories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Liquidations_Head'
CREATE INDEX [IX_FK_Liquidations_Head]
ON [dbo].[Liquidations]
    ([HeadOfDep]);
GO

-- Creating foreign key on [EmployeeId] in table 'Liquidations'
ALTER TABLE [dbo].[Liquidations]
ADD CONSTRAINT [FK_Liquidations_Employees]
    FOREIGN KEY ([EmployeeId])
    REFERENCES [dbo].[Employees]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Liquidations_Employees'
CREATE INDEX [IX_FK_Liquidations_Employees]
ON [dbo].[Liquidations]
    ([EmployeeId]);
GO

-- Creating foreign key on [OfficeId] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [FK_Employees_Offices]
    FOREIGN KEY ([OfficeId])
    REFERENCES [dbo].[Offices]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Employees_Offices'
CREATE INDEX [IX_FK_Employees_Offices]
ON [dbo].[Employees]
    ([OfficeId]);
GO

-- Creating foreign key on [PRId] in table 'PAR'
ALTER TABLE [dbo].[PAR]
ADD CONSTRAINT [FK_PAR_PurchaseRequests]
    FOREIGN KEY ([PRId])
    REFERENCES [dbo].[PurchaseRequests]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PAR_PurchaseRequests'
CREATE INDEX [IX_FK_PAR_PurchaseRequests]
ON [dbo].[PAR]
    ([PRId]);
GO

-- Creating foreign key on [PARId] in table 'PARDetails'
ALTER TABLE [dbo].[PARDetails]
ADD CONSTRAINT [FK_PARDetails_PAR]
    FOREIGN KEY ([PARId])
    REFERENCES [dbo].[PAR]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PARDetails_PAR'
CREATE INDEX [IX_FK_PARDetails_PAR]
ON [dbo].[PARDetails]
    ([PARId]);
GO

-- Creating foreign key on [PRId] in table 'ICS'
ALTER TABLE [dbo].[ICS]
ADD CONSTRAINT [FK_ICS_PurchaseRequests]
    FOREIGN KEY ([PRId])
    REFERENCES [dbo].[PurchaseRequests]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ICS_PurchaseRequests'
CREATE INDEX [IX_FK_ICS_PurchaseRequests]
ON [dbo].[ICS]
    ([PRId]);
GO

-- Creating foreign key on [ICSId] in table 'ICSDetails'
ALTER TABLE [dbo].[ICSDetails]
ADD CONSTRAINT [FK_ICSDetails_ICS]
    FOREIGN KEY ([ICSId])
    REFERENCES [dbo].[ICS]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ICSDetails_ICS'
CREATE INDEX [IX_FK_ICSDetails_ICS]
ON [dbo].[ICSDetails]
    ([ICSId]);
GO

-- Creating foreign key on [ActionId] in table 'DocumentActions'
ALTER TABLE [dbo].[DocumentActions]
ADD CONSTRAINT [FK_DocumentActions_DocumentActions1]
    FOREIGN KEY ([ActionId])
    REFERENCES [dbo].[DocumentActions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DocumentActions_DocumentActions1'
CREATE INDEX [IX_FK_DocumentActions_DocumentActions1]
ON [dbo].[DocumentActions]
    ([ActionId]);
GO

-- Creating foreign key on [Letters_Id] in table 'OBRInLetters'
ALTER TABLE [dbo].[OBRInLetters]
ADD CONSTRAINT [FK_OBRInLetters_Letters]
    FOREIGN KEY ([Letters_Id])
    REFERENCES [dbo].[Letters]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Obligations_Id] in table 'OBRInLetters'
ALTER TABLE [dbo].[OBRInLetters]
ADD CONSTRAINT [FK_OBRInLetters_Obligations]
    FOREIGN KEY ([Obligations_Id])
    REFERENCES [dbo].[Obligations]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OBRInLetters_Obligations'
CREATE INDEX [IX_FK_OBRInLetters_Obligations]
ON [dbo].[OBRInLetters]
    ([Obligations_Id]);
GO

-- Creating foreign key on [ParentId] in table 'TrashBin'
ALTER TABLE [dbo].[TrashBin]
ADD CONSTRAINT [FK_TrashBin_TrashBin]
    FOREIGN KEY ([ParentId])
    REFERENCES [dbo].[TrashBin]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TrashBin_TrashBin'
CREATE INDEX [IX_FK_TrashBin_TrashBin]
ON [dbo].[TrashBin]
    ([ParentId]);
GO

-- Creating foreign key on [OfficeId] in table 'TrashBin'
ALTER TABLE [dbo].[TrashBin]
ADD CONSTRAINT [FK_TrashBin_Offices]
    FOREIGN KEY ([OfficeId])
    REFERENCES [dbo].[Offices]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TrashBin_Offices'
CREATE INDEX [IX_FK_TrashBin_Offices]
ON [dbo].[TrashBin]
    ([OfficeId]);
GO

-- Creating foreign key on [EmployeeId] in table 'Signatories'
ALTER TABLE [dbo].[Signatories]
ADD CONSTRAINT [FK_Signatories_Employees]
    FOREIGN KEY ([EmployeeId])
    REFERENCES [dbo].[Employees]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Signatories_Employees'
CREATE INDEX [IX_FK_Signatories_Employees]
ON [dbo].[Signatories]
    ([EmployeeId]);
GO

-- Creating foreign key on [OfficeId] in table 'Years'
ALTER TABLE [dbo].[Years]
ADD CONSTRAINT [FK_Years_Offices]
    FOREIGN KEY ([OfficeId])
    REFERENCES [dbo].[Offices]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Years_Offices'
CREATE INDEX [IX_FK_Years_Offices]
ON [dbo].[Years]
    ([OfficeId]);
GO

-- Creating foreign key on [PreparedBy] in table 'AIReports'
ALTER TABLE [dbo].[AIReports]
ADD CONSTRAINT [FK_AIReports_Users]
    FOREIGN KEY ([PreparedBy])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AIReports_Users'
CREATE INDEX [IX_FK_AIReports_Users]
ON [dbo].[AIReports]
    ([PreparedBy]);
GO

-- Creating foreign key on [CreatedBy] in table 'DocumentActions'
ALTER TABLE [dbo].[DocumentActions]
ADD CONSTRAINT [FK_DocumentActions_Users]
    FOREIGN KEY ([CreatedBy])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DocumentActions_Users'
CREATE INDEX [IX_FK_DocumentActions_Users]
ON [dbo].[DocumentActions]
    ([CreatedBy]);
GO

-- Creating foreign key on [CreatedBy] in table 'Letters'
ALTER TABLE [dbo].[Letters]
ADD CONSTRAINT [FK_Letters_Users]
    FOREIGN KEY ([CreatedBy])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Letters_Users'
CREATE INDEX [IX_FK_Letters_Users]
ON [dbo].[Letters]
    ([CreatedBy]);
GO

-- Creating foreign key on [CreatedBy] in table 'Logs'
ALTER TABLE [dbo].[Logs]
ADD CONSTRAINT [FK_Logs_Users]
    FOREIGN KEY ([CreatedBy])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Logs_Users'
CREATE INDEX [IX_FK_Logs_Users]
ON [dbo].[Logs]
    ([CreatedBy]);
GO

-- Creating foreign key on [CreatedBy] in table 'Obligations'
ALTER TABLE [dbo].[Obligations]
ADD CONSTRAINT [FK_Obligations_Users]
    FOREIGN KEY ([CreatedBy])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Obligations_Users'
CREATE INDEX [IX_FK_Obligations_Users]
ON [dbo].[Obligations]
    ([CreatedBy]);
GO

-- Creating foreign key on [OfficeId] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [FK_Users_Offices]
    FOREIGN KEY ([OfficeId])
    REFERENCES [dbo].[Offices]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Users_Offices'
CREATE INDEX [IX_FK_Users_Offices]
ON [dbo].[Users]
    ([OfficeId]);
GO

-- Creating foreign key on [PreparedBy] in table 'PIS'
ALTER TABLE [dbo].[PIS]
ADD CONSTRAINT [FK_PIS_Users]
    FOREIGN KEY ([PreparedBy])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PIS_Users'
CREATE INDEX [IX_FK_PIS_Users]
ON [dbo].[PIS]
    ([PreparedBy]);
GO

-- Creating foreign key on [UserId] in table 'UserClaims'
ALTER TABLE [dbo].[UserClaims]
ADD CONSTRAINT [FK_UserClaims_Users]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserClaims_Users'
CREATE INDEX [IX_FK_UserClaims_Users]
ON [dbo].[UserClaims]
    ([UserId]);
GO

-- Creating foreign key on [UserId] in table 'UserLogins'
ALTER TABLE [dbo].[UserLogins]
ADD CONSTRAINT [FK_UserLogins_Users]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserLogins_Users'
CREATE INDEX [IX_FK_UserLogins_Users]
ON [dbo].[UserLogins]
    ([UserId]);
GO

-- Creating foreign key on [RoutedDocuments_Id] in table 'UsersInDocumentActions'
ALTER TABLE [dbo].[UsersInDocumentActions]
ADD CONSTRAINT [FK_UsersInDocumentActions_DocumentActions]
    FOREIGN KEY ([RoutedDocuments_Id])
    REFERENCES [dbo].[DocumentActions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [RoutedToUsers_Id] in table 'UsersInDocumentActions'
ALTER TABLE [dbo].[UsersInDocumentActions]
ADD CONSTRAINT [FK_UsersInDocumentActions_Users]
    FOREIGN KEY ([RoutedToUsers_Id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsersInDocumentActions_Users'
CREATE INDEX [IX_FK_UsersInDocumentActions_Users]
ON [dbo].[UsersInDocumentActions]
    ([RoutedToUsers_Id]);
GO

-- Creating foreign key on [UserRoles_Id] in table 'UsersInRoles'
ALTER TABLE [dbo].[UsersInRoles]
ADD CONSTRAINT [FK_UsersInRoles_UserRoles]
    FOREIGN KEY ([UserRoles_Id])
    REFERENCES [dbo].[UserRoles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Users_Id] in table 'UsersInRoles'
ALTER TABLE [dbo].[UsersInRoles]
ADD CONSTRAINT [FK_UsersInRoles_Users]
    FOREIGN KEY ([Users_Id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsersInRoles_Users'
CREATE INDEX [IX_FK_UsersInRoles_Users]
ON [dbo].[UsersInRoles]
    ([Users_Id]);
GO

-- Creating foreign key on [ObRId] in table 'PayrollOT'
ALTER TABLE [dbo].[PayrollOT]
ADD CONSTRAINT [FK_PayrollOT_Obligations]
    FOREIGN KEY ([ObRId])
    REFERENCES [dbo].[Obligations]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PayrollOT_Obligations'
CREATE INDEX [IX_FK_PayrollOT_Obligations]
ON [dbo].[PayrollOT]
    ([ObRId]);
GO

-- Creating foreign key on [OfficeId] in table 'Letters'
ALTER TABLE [dbo].[Letters]
ADD CONSTRAINT [FK_Letters_Offices]
    FOREIGN KEY ([OfficeId])
    REFERENCES [dbo].[Offices]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Letters_Offices'
CREATE INDEX [IX_FK_Letters_Offices]
ON [dbo].[Letters]
    ([OfficeId]);
GO

-- Creating foreign key on [CreatedBy] in table 'Files'
ALTER TABLE [dbo].[Files]
ADD CONSTRAINT [FK_Files_Users]
    FOREIGN KEY ([CreatedBy])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Files_Users'
CREATE INDEX [IX_FK_Files_Users]
ON [dbo].[Files]
    ([CreatedBy]);
GO

-- Creating foreign key on [EmployeeId] in table 'ItenaryofTravels'
ALTER TABLE [dbo].[ItenaryofTravels]
ADD CONSTRAINT [FK_ItenaryofTravels_Employees]
    FOREIGN KEY ([EmployeeId])
    REFERENCES [dbo].[Employees]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ItenaryofTravels_Employees'
CREATE INDEX [IX_FK_ItenaryofTravels_Employees]
ON [dbo].[ItenaryofTravels]
    ([EmployeeId]);
GO

-- Creating foreign key on [OBRId] in table 'ItenaryofTravels'
ALTER TABLE [dbo].[ItenaryofTravels]
ADD CONSTRAINT [FK_ItenaryofTravels_Obligations]
    FOREIGN KEY ([OBRId])
    REFERENCES [dbo].[Obligations]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ItenaryofTravels_Obligations'
CREATE INDEX [IX_FK_ItenaryofTravels_Obligations]
ON [dbo].[ItenaryofTravels]
    ([OBRId]);
GO

-- Creating foreign key on [RoutedToOfficeId] in table 'DocumentActions'
ALTER TABLE [dbo].[DocumentActions]
ADD CONSTRAINT [FK_DocumentActions_Offices]
    FOREIGN KEY ([RoutedToOfficeId])
    REFERENCES [dbo].[Offices]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DocumentActions_Offices'
CREATE INDEX [IX_FK_DocumentActions_Offices]
ON [dbo].[DocumentActions]
    ([RoutedToOfficeId]);
GO

-- Creating foreign key on [OfficeId] in table 'RISHeader'
ALTER TABLE [dbo].[RISHeader]
ADD CONSTRAINT [FK_RISHeader_Offices]
    FOREIGN KEY ([OfficeId])
    REFERENCES [dbo].[Offices]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RISHeader_Offices'
CREATE INDEX [IX_FK_RISHeader_Offices]
ON [dbo].[RISHeader]
    ([OfficeId]);
GO

-- Creating foreign key on [PRId] in table 'RISHeader'
ALTER TABLE [dbo].[RISHeader]
ADD CONSTRAINT [FK_RISHeader_PurchaseRequests]
    FOREIGN KEY ([PRId])
    REFERENCES [dbo].[PurchaseRequests]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RISHeader_PurchaseRequests'
CREATE INDEX [IX_FK_RISHeader_PurchaseRequests]
ON [dbo].[RISHeader]
    ([PRId]);
GO

-- Creating foreign key on [RISId] in table 'RISDetails'
ALTER TABLE [dbo].[RISDetails]
ADD CONSTRAINT [FK_RISDetails_RISHeader]
    FOREIGN KEY ([RISId])
    REFERENCES [dbo].[RISHeader]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RISDetails_RISHeader'
CREATE INDEX [IX_FK_RISDetails_RISHeader]
ON [dbo].[RISDetails]
    ([RISId]);
GO

-- Creating foreign key on [IOTId] in table 'ItenaryDetails'
ALTER TABLE [dbo].[ItenaryDetails]
ADD CONSTRAINT [FK_ItenaryDetails_ItenaryofTravels]
    FOREIGN KEY ([IOTId])
    REFERENCES [dbo].[ItenaryofTravels]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ItenaryDetails_ItenaryofTravels'
CREATE INDEX [IX_FK_ItenaryDetails_ItenaryofTravels]
ON [dbo].[ItenaryDetails]
    ([IOTId]);
GO

-- Creating foreign key on [ApprovedBy] in table 'ItenaryofTravels'
ALTER TABLE [dbo].[ItenaryofTravels]
ADD CONSTRAINT [FK_ItenaryofTravels_ApprovedBy]
    FOREIGN KEY ([ApprovedBy])
    REFERENCES [dbo].[Employees]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ItenaryofTravels_ApprovedBy'
CREATE INDEX [IX_FK_ItenaryofTravels_ApprovedBy]
ON [dbo].[ItenaryofTravels]
    ([ApprovedBy]);
GO

-- Creating foreign key on [EmployeeId] in table 'PayrollOTDetails'
ALTER TABLE [dbo].[PayrollOTDetails]
ADD CONSTRAINT [FK_PayrollOTDetails_Employees]
    FOREIGN KEY ([EmployeeId])
    REFERENCES [dbo].[Employees]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PayrollOTDetails_Employees'
CREATE INDEX [IX_FK_PayrollOTDetails_Employees]
ON [dbo].[PayrollOTDetails]
    ([EmployeeId]);
GO

-- Creating foreign key on [PayrollOTId] in table 'PayrollOTDetails'
ALTER TABLE [dbo].[PayrollOTDetails]
ADD CONSTRAINT [FK_PayrollOTDetails_PayrollOT]
    FOREIGN KEY ([PayrollOTId])
    REFERENCES [dbo].[PayrollOT]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PayrollOTDetails_PayrollOT'
CREATE INDEX [IX_FK_PayrollOTDetails_PayrollOT]
ON [dbo].[PayrollOTDetails]
    ([PayrollOTId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------