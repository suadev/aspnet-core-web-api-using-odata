This repo aims to show that how easily OData can be used with asp.net core web api projects to perform all CRUD operations.

This is a simple api that consist of two entities called Product and ProductCategory.

You can check following sample OData requests and results. 

if you like Postman, just import AspNetCore_OData.postman_collection.json file and you will see more sample query in Get folders.

<img src="https://raw.githubusercontent.com/suadev/aspnet-core-web-api-using-odata-temp/master/postman.JPG?token=ABNFAW3OUW454CL2CBRFKGS5GN6DY" />


#### Get All Categories - http://localhost:5000/odata/product_categories?$count=true

```javascript
{
    "@odata.context": "http://localhost:5000/odata/$metadata#product_categories",
    "@odata.count": 3,
    "value": [
        {
            "id": "1236a458-0802-4340-bdd4-05859c9aaaad",
            "categoryName": "Headphones"
        },
        {
            "id": "8b726886-e719-413c-a125-939ee5af387d",
            "categoryName": "TV"
        },
        {
            "id": "a65bc1ae-c1c7-4c20-8b3b-4b48490d3fb0",
            "categoryName": "Computers"
        }
    ]
}
```
<hr>

 #### Get All Products - http://localhost:5000/odata/products?$count=true

```javascript
 {
    "@odata.context": "http://localhost:5000/odata/$metadata#products",
    "@odata.count": 3,
    "value": [
        {
            "id": "6d42ac79-2b65-460d-9991-22b86ad66fb9",
            "productName": "JBL Tune",
            "categoryId": "1236a458-0802-4340-bdd4-05859c9aaaad",
            "description": "JBL Tune 500BT On-Ear",
            "price": 15,
            "weight": 0.3
        },
        {
            "id": "78a4a7db-073f-4ad9-a157-2a9da0ceae38",
            "productName": "HP Zbook",
            "categoryId": "a65bc1ae-c1c7-4c20-8b3b-4b48490d3fb0",
            "description": "HP Zbook Laptop",
            "price": 2000,
            "weight": 3
        },
        {
            "id": "aec7ce71-bfa6-4b0f-8aef-78816a31c9fa",
            "productName": "LG 32-Inch",
            "categoryId": "8b726886-e719-413c-a125-939ee5af387d",
            "description": "LG 32-Inch 720p LED TV",
            "price": 12000,
            "weight": 60
        }
    ]
}
```
<hr>

#### Get Product by ID - http://localhost:5000/odata/products(010b34c3-5d91-4f15-a926-a4edbc3a9770)

```javascript
{
    "@odata.context": "http://localhost:5000/odata/$metadata#products/$entity",
    "id": "6d42ac79-2b65-460d-9991-22b86ad66fb9",
    "productName": "JBL Tune",
    "categoryId": "1236a458-0802-4340-bdd4-05859c9aaaad",
    "description": "JBL Tune 500BT On-Ear",
    "price": 15,
    "weight": 0.3
}
```
<hr>

#### Filter by Price - http://localhost:5000/odata/products?$filter=price%20gt%2010000

```javascript
{
    "@odata.context": "http://localhost:5000/odata/$metadata#products",
    "value": [
        {
            "id": "aec7ce71-bfa6-4b0f-8aef-78816a31c9fa",
            "productName": "LG 32-Inch",
            "categoryId": "8b726886-e719-413c-a125-939ee5af387d",
            "description": "LG 32-Inch 720p LED TV",
            "price": 12000,
            "weight": 60
        }
    ]
}
```
<hr>

#### Order by Price - http://localhost:5000/odata/products?$orderby=price

```javascript
{
    "@odata.context": "http://localhost:5000/odata/$metadata#products",
    "value": [
        {
            "id": "6d42ac79-2b65-460d-9991-22b86ad66fb9",
            "productName": "JBL Tune",
            "categoryId": "1236a458-0802-4340-bdd4-05859c9aaaad",
            "description": "JBL Tune 500BT On-Ear",
            "price": 15,
            "weight": 0.3
        },
        {
            "id": "78a4a7db-073f-4ad9-a157-2a9da0ceae38",
            "productName": "HP Zbook",
            "categoryId": "a65bc1ae-c1c7-4c20-8b3b-4b48490d3fb0",
            "description": "HP Zbook Laptop",
            "price": 2000,
            "weight": 3
        },
        {
            "id": "aec7ce71-bfa6-4b0f-8aef-78816a31c9fa",
            "productName": "LG 32-Inch",
            "categoryId": "8b726886-e719-413c-a125-939ee5af387d",
            "description": "LG 32-Inch 720p LED TV",
            "price": 12000,
            "weight": 60
        }
    ]
}
```
<hr>

#### Skip & Take - http://localhost:5000/odata/products?$count=true&$top=2&$skip=1

```javascript
{
    "@odata.context": "http://localhost:5000/odata/$metadata#products",
    "@odata.count": 3,
    "value": [
        {
            "id": "78a4a7db-073f-4ad9-a157-2a9da0ceae38",
            "productName": "HP Zbook",
            "categoryId": "a65bc1ae-c1c7-4c20-8b3b-4b48490d3fb0",
            "description": "HP Zbook Laptop",
            "price": 2000,
            "weight": 3
        },
        {
            "id": "aec7ce71-bfa6-4b0f-8aef-78816a31c9fa",
            "productName": "LG 32-Inch",
            "categoryId": "8b726886-e719-413c-a125-939ee5af387d",
            "description": "LG 32-Inch 720p LED TV",
            "price": 12000,
            "weight": 60
        }
    ]
}
```
<hr>

#### Get Product Count - http://localhost:5000/odata/products?$top=0&$count=true

```javascript
{
    "@odata.context": "http://localhost:5000/odata/$metadata#products",
    "@odata.count": 3,
    "value": []
}
```
<hr>

#### Select Specific Fields - http://localhost:5000/odata/products?$select=id,productname

```javascript
{
    "@odata.context": "http://localhost:5000/odata/$metadata#products(id,productName)",
    "value": [
        {
            "id": "6d42ac79-2b65-460d-9991-22b86ad66fb9",
            "productName": "JBL Tune"
        },
        {
            "id": "78a4a7db-073f-4ad9-a157-2a9da0ceae38",
            "productName": "HP Zbook"
        },
        {
            "id": "aec7ce71-bfa6-4b0f-8aef-78816a31c9fa",
            "productName": "LG 32-Inch"
        }
    ]
}
```
<hr>

#### Expand - http://localhost:5000/odata/products?$expand=category

```javascript
{
    "@odata.context": "http://localhost:5000/odata/$metadata#products",
    "value": [
        {
            "id": "6d42ac79-2b65-460d-9991-22b86ad66fb9",
            "productName": "JBL Tune",
            "categoryId": "1236a458-0802-4340-bdd4-05859c9aaaad",
            "description": "JBL Tune 500BT On-Ear",
            "price": 15,
            "weight": 0.3,
            "category": {
                "id": "1236a458-0802-4340-bdd4-05859c9aaaad",
                "categoryName": "Headphones"
            }
        },
        {
            "id": "78a4a7db-073f-4ad9-a157-2a9da0ceae38",
            "productName": "HP Zbook",
            "categoryId": "a65bc1ae-c1c7-4c20-8b3b-4b48490d3fb0",
            "description": "HP Zbook Laptop",
            "price": 2000,
            "weight": 3,
            "category": {
                "id": "a65bc1ae-c1c7-4c20-8b3b-4b48490d3fb0",
                "categoryName": "Computers"
            }
        },
        {
            "id": "aec7ce71-bfa6-4b0f-8aef-78816a31c9fa",
            "productName": "LG 32-Inch",
            "categoryId": "8b726886-e719-413c-a125-939ee5af387d",
            "description": "LG 32-Inch 720p LED TV",
            "price": 12000,
            "weight": 60,
            "category": {
                "id": "8b726886-e719-413c-a125-939ee5af387d",
                "categoryName": "TV"
            }
        }
    ]
}
```
<hr>

#### Expand and Select - http://localhost:5000/odata/products?$expand=category($select=categoryName)&$select=id,productName

```javascript
{
    "@odata.context": "http://localhost:5000/odata/$metadata#products(id,productName,category(categoryName))",
    "value": [
        {
            "id": "6d42ac79-2b65-460d-9991-22b86ad66fb9",
            "productName": "JBL Tune",
            "category": {
                "categoryName": "Headphones"
            }
        },
        {
            "id": "78a4a7db-073f-4ad9-a157-2a9da0ceae38",
            "productName": "HP Zbook",
            "category": {
                "categoryName": "Computers"
            }
        },
        {
            "id": "aec7ce71-bfa6-4b0f-8aef-78816a31c9fa",
            "productName": "LG 32-Inch",
            "category": {
                "categoryName": "TV"
            }
        }
    ]
}
```
<hr>

### Running Locally

- docker-comppose up (for postgres instance)
- dotnet run

<hr>

### Migration

 - dotnet ef migrations add "init" -c ProductDbContext -p src/OData.WebApi --output-dir Data/Migrations
