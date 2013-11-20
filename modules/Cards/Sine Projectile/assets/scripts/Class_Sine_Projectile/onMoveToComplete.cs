function Class_Sine_Projectile::onMoveToComplete(%this)
{

if (%this.Simset_Vector_2D_Wave_Nodes.getCount()==0)
{

%this.Simset_Vector_2D_Wave_Nodes.delete();

%this.Module_ID_Parent.Simset_Objects.remove(%this);

%this.safeDelete();

return;

}

%Vector_2D_Vector=%this.Simset_Vector_2D_Wave_Nodes.getObject(0);

%Vector_2D_Destination="0 0";
%Vector_2D_Destination.X=%Vector_2D_Vector.X;
%Vector_2D_Destination.Y=%Vector_2D_Vector.Y;

%this.Simset_Vector_2D_Wave_Nodes.remove(%Vector_2D_Vector);

%Vector_2D_Vector.delete();

%this.moveTo(%Vector_2D_Destination,20,false,false);

}
