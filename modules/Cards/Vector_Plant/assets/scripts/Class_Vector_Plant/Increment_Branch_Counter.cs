function Class_Vector_Plant::Increment_Branch_Counter(%this)
{

%this.Int_Branch_Count++;

if (isObject(%this.Plant_Parent))
{

%this.Plant_Parent.Increment_Branch_Counter();

}

}
