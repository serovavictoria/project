using System;
using System.IO;
using System.Linq;
using UnityEngine;

namespace Scripts
{
    [CreateAssetMenu(fileName = "NewQuest", menuName = "ScriptableObjects/Quest", order = 1)]
    public class QuestScriptableObject : ScriptableObject
    {
        [SerializeField]
        private String questDesc;
        public String QuestDesc { get { return questDesc; } }

        [SerializeField]
        private Sprite imageDescription;
        public Sprite ImageDescription { get { return imageDescription; } }

        [SerializeField]
        private Sprite clue;
        public Sprite Clue { get {  return clue; } }

        [SerializeField]
        private String rightAnswer;
        [SerializeField]
        private String defaultAnswer;
        public String RightAnswer { get { return rightAnswer; } }

        public bool IsComplete { get; set; }

        [SerializeField]
        private QuestScriptableObject[] requiredCompletedQuests;

        [SerializeField]
        private string nameImageQuestDescription;
        [SerializeField]
        private string nameImageQuestClue;
        [SerializeField]
        private string nameStringRightAnswer;


        public bool CanCompleteQuest
        {
            get
            {
                if (requiredCompletedQuests == null || requiredCompletedQuests.Length == 0) return true;

                return requiredCompletedQuests.All(quest => quest.IsComplete);
            }
        }

        private void OnEnable()
        {
            IsComplete = false;
            LoadImageDesc(nameImageQuestDescription);
            LoadImageClue(nameImageQuestClue);
            LoadRightAnswer(nameStringRightAnswer);
        }

        private void LoadRightAnswer(string name)
        {
            try
            {
                // Read all lines from the file and join them into a single string
                string[] lines = File.ReadAllLines(@"C:\DiplomImages\" + name);
                string text = string.Join(Environment.NewLine, lines);

                rightAnswer = text;
            }
            catch (Exception ex)
            {
                rightAnswer = defaultAnswer;
                Debug.LogWarning("Не найден файл с правильным ответом");
            }
        }

        private void LoadImageDesc(string name)
        {
            Sprite sprite = LoadNewSprite(@"C:\DiplomImages\" + name);

            if (sprite == null ) 
            { 
                Debug.LogWarning("Не найден файл");
                return;
            }

            imageDescription = sprite;
        }

        private void LoadImageClue(string name)
        {
            Sprite sprite = LoadNewSprite(@"C:\DiplomImages\" + name);

            if (sprite == null)
            {
                Debug.LogWarning("Не найден файл");
                return;
            }

            clue = sprite;
        }

        public Texture2D LoadTexture(string FilePath)
        {

            // Load a PNG or JPG file from disk to a Texture2D
            // Returns null if load fails

            Texture2D Tex2D;
            byte[] FileData;

            if (File.Exists(FilePath))
            {
                FileData = File.ReadAllBytes(FilePath);
                Tex2D = new Texture2D(2, 2);           // Create new "empty" texture
                if (Tex2D.LoadImage(FileData))           // Load the imagedata into the texture (size is set automatically)
                    return Tex2D;                 // If data = readable -> return texture
            }
            return null;                     // Return null if load failed
        }

        public Sprite LoadNewSprite(string FilePath, float PixelsPerUnit = 100.0f, SpriteMeshType spriteType = SpriteMeshType.Tight)
        {

            // Load a PNG or JPG image from disk to a Texture2D, assign this texture to a new sprite and return its reference

            Texture2D SpriteTexture = LoadTexture(FilePath);

            if (SpriteTexture == null) { return null; }

            Sprite NewSprite = Sprite.Create(SpriteTexture, new Rect(0, 0, SpriteTexture.width, SpriteTexture.height), new Vector2(0, 0), PixelsPerUnit, 0, spriteType);

            return NewSprite;
        }
    }
}
