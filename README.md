
# WebApi

Simple CRUD Web Api made with .net core 6. It contains data with movies from netflix streaming service.
It is using the dataset from my other Repository [MoviesData](https://github.com/Zi3mko/MoviesData).


Currently it contains the basic CRUD endpoints but i plan to expand it in the near future and add some kind of Authentication and Authorization.



## API Reference

#### Get all items

```http
  GET /api/Movie
```

#### Get item

```http
  GET /api/Movie/${id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `int` | **Required**. Id of item to fetch |

```http
  POST /api/Movie
```

| Parameter | Type     | Description                |
| :-------- | :------- | :------------------------- |
| `id`      | `int`    | **NOT Required**.          |
| `title`   | `string` | Name of the movie you want to instert |
| `director`| `string` | Name and the surname of the director |
| `cast`    | `string` | Insert the entire cast |
| `releaseYear`| `string`| Release year of the movie |
| `duration`| `string` | Duration of a movie in minutes|
| `categories`| `string`| Categories that movie belongs to. For example: Comedy etc.|
| `description`| `string`| Brief description of the movie|

```http
  PUT /api/Movie
```
| Parameter | Type     | Description                |
| :-------- | :------- | :------------------------- |
| `id`      | `int`    | **Required** Id of the movie you want to edit          |
| `title`   | `string` | Name of the movie |
| `director`| `string` | Name and the surname of the director |
| `cast`    | `string` | Entire cast |
| `releaseYear`| `string`| Release year of the movie |
| `duration`| `string` | Duration of a movie in minutes|
| `categories`| `string`| Categories that movie belongs to. For example: Comedy etc.|
| `description`| `string`| Brief description of the movie|

