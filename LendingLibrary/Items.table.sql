/* 
 *	Items.table.sql
 *	Cody Fagley
 *	Authored on May 14, 2017
 */

/*
 *	Table containing lent item information
 */
CREATE TABLE [dbo].[Items]
(
	--  Primary Key
	ITEM_ID int NOT NULL PRIMARY KEY IDENTITY(1,1),
	
	--  Name of item being lent
	ITEM_NAME varchar NOT NULL,
	--  Person whom the item is lent to
	ITEM_LENDEE varchar NOT NULL,
	
	--  OPTIONAL - Date that item is lent: YYYY-MM-DD
	ITEM_DATE_LENT date NULL,
	--  OPTIONAL - Date that item is returned: YY-MM-DD
	ITEM_DATE_RETURNED date NULL,
	
	--  OPTIONAL - Description of the item
	ITEM_DESCRIPTION varchar NULL,

)
