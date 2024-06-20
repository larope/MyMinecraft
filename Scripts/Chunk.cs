public class Chunk
{
    private const int CHUNKWIDTH = 16;
    private const int CHUNKHEIGHT = 128;

    public Block[,,] blocks = new Block[CHUNKWIDTH, CHUNKWIDTH, CHUNKHEIGHT];

    public Chunk()
    {
        for (int x = 0; x < CHUNKWIDTH; x++)
        {
            for (int y = 0; y < CHUNKWIDTH; y++)
            {
                for (int z = 0; z < CHUNKHEIGHT; z++)
                {
                    blocks[x, y, z] = new Block(BlockType.air, false);
                }
            }    
        }
    }
    
    public Chunk(Block[,,] blocks)
    {
        this.blocks = blocks;
    }
}
