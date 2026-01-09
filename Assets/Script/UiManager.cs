using TMPro;
using Unity.Android.Gradle;
using UnityEngine;
using UnityEngine.UI;
using static Unity.Collections.AllocatorManager;
public class StoryBlock
{
    public string story;
    public string option1Text;
    public string option2Text;
    public StoryBlock option1Block;
    public StoryBlock option2Block;

    public StoryBlock(string story, string option1Text = "", string option2Text = "", StoryBlock option1Block = null, StoryBlock option2Block = null)
    {
        this.story = story;
        this.option1Text = option1Text;
        this.option2Text = option2Text;
        this.option1Block = option1Block;
        this.option2Block = option2Block;
    }
}
public class UiManager : MonoBehaviour
{
    StoryBlock currentBlock;
    public Text welcomeText;
    public Button option1;
    public Button option2;
    static StoryBlock block8 = new StoryBlock("You decided to sit there forever, Game over", "GAME OVERRR", "YOU LOSEEEEEEEE");
    static StoryBlock block7 = new StoryBlock("You've approached the, wooden doors, inserted the key, tirned and .. it opens. You are free", "Cogratulationnnnnnnn!", "YOU WINNNNNN");
    static StoryBlock block6 = new StoryBlock("The floor is covered with huge amounts of the small stones. You started to move your hand around them to maybe find something useful.. and there is somthing ! It's key!", "Try to unlock doors", "Do nothing", block7, block8);
    static StoryBlock block5 = new StoryBlock("You started reaching into the pocket, but nothing could be found there", "Check the doors", "Inspect floor", block3, block6);
    static StoryBlock block4 = new StoryBlock("Because you quickly get tired of screaming, you decided to sit down and devise an escape route", "Ispect floor", "Check your pocket", block6, block5);
    static StoryBlock block3 = new StoryBlock("You noitced a big, wooden doors on th opposite side of the room. After quick inspection, it looks like they are closed. But there is a key lock!", "Do nothing", "Ispect floor", block8, block6);
    static StoryBlock block2 = new StoryBlock("You started to panic and screamed for help, but it looks like, you're here completly alone", "Sit down", "Check the door", block4, block3);
    static StoryBlock block1 = new StoryBlock("You just woke up in a small, dark cell in an old castle.", "Look for other people", "Check the door", block2, block3);

    void Start()
    {
        //DisplayBlock(block1);
    }

    //public void DisplayBlock(StoryBlock block)
    //{
    //    if(block == block7)
    //    {
    //        welcomeText.color = Color.green;
    //    }
    //    if(block == block8)
    //    {
    //        welcomeText.color = Color.red;
    //    }
    //    welcomeText.text = block.story;
    //    option1.GetComponentInChildren<Text>().text = block.option1Text;        
    //    option2.GetComponentInChildren<Text>().text = block.option2Text;

    //    currentBlock = block;
    //}

    //public void btn1Click()
    //{
    //    DisplayBlock(currentBlock.option1Block);
    //}
    //public void btn2Click()
    //{
    //    DisplayBlock(currentBlock.option2Block);
    //}
}
