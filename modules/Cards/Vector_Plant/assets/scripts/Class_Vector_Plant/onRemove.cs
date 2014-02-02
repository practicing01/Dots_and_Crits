function Class_Vector_Plant::onRemove(%this)
{

cancel(%this.Schedule_AI);

%this.Simset_Colliding_Objects.delete();

}
