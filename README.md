# Unity Engine

## Spis treści
- [Unity Engine](#unity-engine)
  - [Spis treści](#spis-treści)
  - [Skrypty](#skrypty)


## Skrypty
 - `GetComponent` - instrukcja która pomoże dostać się do danego komponentu

by zmienić kolor sprite'a:
```c#
void Start(){
    GetComponent<SpriteRenderer>().color = Color.blue;
}
```
jeśli do danego komponentu odwołujemy się więcej niż raz to lepiej zapisać takie powiązanie w zmiennej:

```c#
SpriteRenderer spriteRenderer;

void Start(){
    spriteRenderer = GetComponent<SpriteRenderer>();
    spriteRenderer.color = Color.red;
}
```

Serialized Field - dzięki temu zmienna jest serializowana i będzie pokazana w inspektorze

```c#
[SerializedField] Transform trans;
```
![Inspektor](ss/serialField.png)
lub transform w taki sposób:
`transform.position = ...`