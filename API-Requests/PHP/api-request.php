<?php
class ApiRequest 
{
    private string $baseUrl;

    private string $token;

    function __construct(string $baseUrl, string $token)
    {
        $this->baseUrl = $baseUrl;
        $this->token = $token;
    }

    public function getRequest(string $endpoint, $token = null)
    {
        $curl = curl_init($endpoint);
        curl_setopt($curl, CURLOPT_RETURNTRANSFER, true);
        curl_setopt($curl, CURLOPT_FOLLOWLOCATION, true);
        if ($token)
        {
            $headers = ["Authorization: Bearer $token"];
            curl_setopt($curl, CURLOPT_HTTPHEADER, $headers);
        }
        $result = curl_exec($curl);
        curl_close($curl);
        return $result;
    }

    public function postRequest(string $endpoint, object $data)
    {
        $dataStr = json_encode($data);
        $headers = [
            "Content-Type: application/json",
            "Authorization: Bearer $this->token",
            "Content-Length: ". strlen($dataStr),
        ];
        $curl = curl_init($endpoint);
        curl_setopt($curl, CURLOPT_RETURNTRANSFER, true);
        curl_setopt($curl, CURLOPT_FOLLOWLOCATION, true);
        curl_setopt($curl, CURLOPT_POST, true);
        //curl_setopt($curl, CURLOPT_CUSTOMREQUEST, "POST");
        curl_setopt($curl, CURLOPT_POSTFIELDS, $dataStr);
        curl_setopt($curl, CURLOPT_HTTPHEADER, $headers);
        $result = curl_exec($curl);
        curl_close($curl);
        return $result;
    }

    public function getBooks(): array
    {
        $result = $this->getRequest("$this->baseUrl/api/books");
        $booksArray = json_decode($result);
        return $booksArray;
    }

    public function getBook(int $bookId): object
    {
        $result = $this->getRequest("$this->baseUrl/api/books/$bookId");
        $book = json_decode($result);
        return $book;        
    }

    public function getAdmins(): array
    {
        $result = $this->getRequest("$this->baseUrl/admin/admins", $this->token);
        $admins = json_decode($result);     
        return $admins;
    }

    public function addBook($bookData)
    {
       $result = $this->postRequest("$this->baseUrl/admin/book/create", $bookData);
       $newBook = json_decode($result);
       return $newBook; 
    }
}

$baseUrl = "http://ojlinks-api.test:8084";
$token = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
$apiRequest  = new ApiRequest($baseUrl, $token);

$books = $apiRequest->getBooks();
if (is_array($books)) {
    $firstBook = $books[0];
    echo "First Book: " . $firstBook->title . " by  " . $firstBook->author;
}

echo "\n";

$bookId = 7;
$book = $apiRequest->getBook($bookId);
echo "Book $bookId: " . $book->title . " by " . $book->author; 

$admins = $apiRequest->getAdmins();
if (is_array($admins))
{
    for($i = 0; $i < count($admins); $i++)
    {
        $admin = $admins[$i];
        echo $admin->firstname . " for ". $admin->lastname . "\n";
    }
}

$bookData = new stdClass();
$bookData->title = "Biology for Kids";
$bookData->author = "Emerson & folks";
$bookData->price = 1750;
$bookData->edition = "3rd Edition";
$bookData->details = "<p>Book for all the kids";
$bookData->subcategoryId = 2;
$newBook = $apiRequest->addBook($bookData);

echo "New Books: $newBook->bookId  $newBook->title by $newBook->author";
