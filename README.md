
# Item Creator v1298

This tool is designed to simplify the process of creating new items for Knight Online v1298 servers. It allows user to create new items without the need to edit each .tbl file and database records separatly, instead it goes through each section filling in information automatically, and by using pre-sets of items.


## Usage

Before you start creating a weapon/armor what you will need is the *.npmesh & icon numbers for the model and icon, then everything you need is an idea what exactly you want. It's pretty simple, first of all you put all the info required by Item_org_us.tbl  as below:

![1](https://github.com/brzezinski-grzegorz/item-creator-v1298/assets/63126985/be3ea1c2-c056-4155-bf80-42f820e4d0df)
![2](https://github.com/brzezinski-grzegorz/item-creator-v1298/assets/63126985/58d8bb1b-cf36-46f7-9bca-174b67fe7e94)

As you can see some of the values are pre-defined by me, some I have made as "Read Only" because they are not very well known/or used in this version of the game, so better not mess with them. After you've put neccesary infromation you just press the button and it saves the Item_Org table as plain TXT file which we can later convert to *.tbl   by table editor. In the next section we have Item_Ext table:

![3](https://github.com/brzezinski-grzegorz/item-creator-v1298/assets/63126985/3aa32f0e-84c8-4938-862f-6261997bc3c6)

In this section you can put all the neccesary information for each upgrade of item from +0 to +10, as you can see above some information have been already passed from the first section, like items name, number, animation etc. so you don't have to do it again, and focus on setting things like damage, defenses etc.

Very important thing here is to set the Item Ext Index Number which goes later to Item_ext table in client.

If you notice anything wrong from first section you can always go back with the button and fix it and come back. If everything is set we go to the last section of creator which is ITEM table in database, and it looks like this:

![4](https://github.com/brzezinski-grzegorz/item-creator-v1298/assets/63126985/a6c608c9-37b9-4c84-b1db-66d46d7695d2)

Once again here the information about item are imported from previous sections, here we have to set only Damage, Hitrate, Evansion Rate, Drop Rate and we can save the item. By default the items are saved as *.txt & .sql (for the ITEM table) in application folder. If you hit finish then you can do either two things, go back to begginng and start adding new item or just close the app:

![5](https://github.com/brzezinski-grzegorz/item-creator-v1298/assets/63126985/336ea571-d512-4e8a-9e8b-ec4421b38b31)

And that's it. Please note that it's still application in beta mode if you run into troubles or you catch something please notify me asap! I will do my best to fix everythin and make the tool complete and fully operational.

The app requires .Net Framework 4 or higher!
