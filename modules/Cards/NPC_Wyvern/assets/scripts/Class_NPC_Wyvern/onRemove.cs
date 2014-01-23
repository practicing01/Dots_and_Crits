function Class_NPC_Wyvern::onRemove(%this)
{

cancel(%this.Schedule_AI);

%this.Simset_Colliding_Objects.delete();

}
