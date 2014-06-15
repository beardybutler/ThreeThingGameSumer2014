#pragma strict

var Health = 100;

public function ApplyDammage (TheDammage : int)
{
	Health -= TheDammage;
	
	if(Health <= 0)
	{
		Dead();
	}
}

function Dead()
{
	Destroy (gameObject);
}