using System.Collections.Generic;
using TextBaseGame.Interfaces;


namespace TextBaseGame.Story
{

    // Reprezintă un capitol
    public class Chapter
    {
        public string Title { get; }
        private Queue<IScene> scenes;

        public Chapter(string title, IEnumerable<IScene> scenes)
        {
            Title = title;
            this.scenes = new Queue<IScene>(scenes);
        }

        public bool HasScenes => scenes.Count > 0;

        public IScene GetNextScene()
        {
            return scenes.Dequeue();
        }
    }
}
