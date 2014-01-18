function Module_Card_Shield::Action_Update_Health(%this,%Player_Information,%Unit_Game_Connection_Handle,%Unit_Object_Index,%Operation,%Amount)
{

%Unit=-1;

for (%x=0;%x<%this.Simset_Objects.getCount();%x++)
{

%Unit=%this.Simset_Objects.getObject(%x);

if (%Unit.Game_Connection_Handle==%Unit_Game_Connection_Handle&&%Unit.Object_Index==%Unit_Object_Index)
{

break;

}

%Unit=-1;

}

if (!isObject(%Unit)){return;}

if (%Operation==0)//Add
{

%Unit.Health+=%Amount;

}
else if (%Operation==1)//Subtract
{

%Unit.Health-=%Amount;

}
else//Set
{

%Unit.Health=%Amount;

}

%Unit.Update_Health();

}
