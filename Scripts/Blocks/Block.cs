public class Block
{
    public BlockType type;
    public bool isInteractable;
    
    public Block(BlockType type, bool isInteractable)
    {
        this.type = type;
        this.isInteractable = isInteractable;
    }

    public void Interact()
    {
        
    }
}