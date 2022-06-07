const https = require('https');
const http = require('http');

class ApiRequest 
{
    constructor(baseUrl, token) {
      this.baseUrl = baseUrl;
      this.token = token;
    }

    async getRequest(url) {
        const responseData = await new Promise((resolve, reject) => {
            http.get(`${this.baseUrl}${url}`, res => {
                let allData = '';
                let books = [];
                res.on('data', data => {        
                    allData += data;
                });
                res.on('end', () => {
                    books = JSON.parse(allData);
                    resolve(books);
                });
            }).on('error', err => {
                reject(err);
            });
        });
        return responseData;
    }

    async postRequest(url, data) {
        const postData = JSON.stringify(data);
        const options = {
          method: 'POST', 
          headers: {
            'Content-Type': 'application/json',
            'Content-Length': postData.length,
          }
        };
        if (this.token) {
            options.headers.Authorization = `Bearer ${this.token}`;
        };
        const responseData = await new Promise((resolve, reject) => {
            const req = http.request(`${this.baseUrl}${url}`, options, res => {
                let allData = '';
                let books = [];
                res.on('data', data => {        
                    allData += data;
                });
                res.on('end', () => {
                    books = JSON.parse(allData);
                    resolve(books);
                });
            }).on('error', err => {
                reject(err);
            });

           req.write(postData);
           req.end();
        });
        return responseData;
    }

    async getBook(bookId) {
       try {
           const data = await this.getRequest(`/api/books/${bookId}`);          
           return data;
       } catch(err) {
           console.log('get err', err);
       }
    }

    async getBooks() {    
       try {           
            const data = await this.getRequest('/api/books');           
            return data;             
       } catch(err) {
           console.log('get err', err);
       }    
    }

    async addBook(bookData) {
        try {           
            const data = await this.postRequest('/admin/book/create', bookData);          
            return data;             
       } catch(err) {
           console.log('post err', err);
       }    
    }
}

const token = 'eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJhZG1pbklkIjoxLCJpYXQiOjE2NTQ1NzQ4MjEsImV4cCI6MTY1NDYwMzYyMSwiaXNzIjoiaHR0cDpvamxpbmtzLWFwaS50ZXN0OjgwODQifQ.DcYXmQ4qZnRrnTWkKmxlARHQt0L9oRlTQnbziJRPvp4';
const baseUrl = 'http://ojlinks-api.test:8084';
const apiRequest = new ApiRequest(baseUrl, token);

apiRequest.getBooks()
          .then(books => {
            if (Array.isArray(books) && books.length > 0) {               
                const firstBook = books[0];
                delete firstBook.details;
                console.log('First Book', firstBook);  
            }
          }).catch(console.log);

apiRequest.getBook(5)
          .then(book => {
              delete book.details;
              console.log('Book 5', book);
          }).catch(console.log);

const bookData = {
    title: "Physics Book",
    author: "Cuoral Sourer & Marra Hadrum",
    edition: "1st",
    price: 3400,
    img: "7.jpg",
    availability: 1,
    subcategoryId: 1,
    details: "<p>Clinical Damatology By Cuoral Sourer & Marra Hadrum </p>"
};

apiRequest.addBook(bookData)
         .then(book => {
            console.log('New Book', book)
         }).catch(console.log);
