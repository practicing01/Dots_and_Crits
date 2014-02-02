function Class_Vector_Plant::Get_Root_Branch_Count(%this)
{

%Plant_Parent=%this.Plant_Parent;

if (!isObject(%Plant_Parent)){return 0;}

%Next_Plant_Parent=0;

while (1)
{

%Next_Plant_Parent=%Plant_Parent.Plant_Parent;

if (!isObject(%Next_Plant_Parent))
{

return %Plant_Parent.Int_Branch_Count;

}

%Plant_Parent=%Next_Plant_Parent;

}

}
