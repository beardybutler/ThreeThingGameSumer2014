//var AudioFile : AudioClip;

function Update() {

//var v : float = Input.GetAxisRaw("Vertical");

if (!(Input.GetAxisRaw("Vertical") > 0.1) && !(Input.GetAxisRaw("Vertical") < -0.1) &&
!(Input.GetAxisRaw("Horizontal") > 0.1) && !(Input.GetAxisRaw("Horizontal") < -0.1))
{
 //   audio.clip = AudioFile;
    audio.Stop();
 
}
}
