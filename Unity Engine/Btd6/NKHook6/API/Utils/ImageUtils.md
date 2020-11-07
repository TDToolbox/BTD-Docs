# ImageUtils

```cs
SpriteMeshType spriteType = SpriteMeshType.Tight;
float PixelsPerUnit = 100f;
TextureFormat format = TextureFormat.BC7;
```

## `.ConvertTextureToSprite()`

```cs
Sprite sprite = ImageUtils.ConvertTextureToSprite(Texture2D texture, float PixelsPerUnit, SpriteMeshType spriteType);
```

## `.LoadNewSprite()`

```cs
Sprite sprite =  ImageUtils.LoadNewSprite(string FilePath, float PixelsPerUnit, SpriteMeshType spriteType);
```

## `.LoadSpriteB64()`

```cs
Sprite sprite = ImageUtils.LoadSpriteB64(string encoded, float PixelsPerUnit, SpriteMeshType spriteType);
```

## `.LoadTexture()`

```cs
Texture2D texture = ImageUtils.LoadTexture(string FilePath);
```

## `.LoadTextureFromBytes()`

```cs
Texture2D texture = ImageUtils.LoadTextureFromBytes(byte[] FileData);
```

## `.LoadTextureFromFile()`

```cs
Texture2D texture = ImageUtils.LoadTextureFromFile(string filePathToImage, TextureFormat format);
```

## `.writeImagetoPNG()`

```cs
ImageUtils.writeImagetoPNG(Image image);
```

## `.writeTextoPNG(Texture2D tex)`

```cs
ImageUtils.writeTextoPNG(Texture2D tex);
```