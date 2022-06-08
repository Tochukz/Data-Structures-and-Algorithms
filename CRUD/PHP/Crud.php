<?php 
class Crud 
{
    private object $connection;

    public function __construct(array $config)
    {
        $host=$config['host'];
        $db = $config['db'];
        $connection = new pdo("mysql:host=$host; dbname=$db", $config['username'], $config['password']); 
        $connection->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
        $this->connection = $connection;
    }

    public function addBook(array $data): array
    {
        $query = $this->connection->prepare(
          "INSERT INTO books(title, author, edition, price, subcategoryId, createdAt, updatedAt) 
           values (:title, :author, :edition, :price, :subcategoryId, :createdAt, :updatedAt)"
        );
        $result = $query->execute([
            ':title'         => $data['title'],
            ':author'        => $data['author'],
            ':edition'       => $data['edition'],
            ':price'         => $data['price'],
            ':subcategoryId' => $data['subcategoryId'],
            ':createdAt'     => date("Y-m-d H:i:s"),
            'updatedAt'      => date("Y-m-d H:i:s"),
        ]);
        $lastId = $this->connection->lastInsertId();        
        return $this->getBook($lastId);
    }

    public function getBook(string $bookId): array
    {
        $query = $this->connection->prepare("SELECT * FROM books WHERE bookId = :bookId");
        $query->execute(['bookId' => $bookId]);
        $data = $query->fetchAll(PDO::FETCH_ASSOC);      
        if (count($data)) {
            return $data[0];
        }
        return [];
    }

    public function getBooks(): array 
    {
        $query = $this->connection->prepare("SELECT * FROM books");
        $query->execute();
        $data = $query->fetchAll(PDO::FETCH_ASSOC);      
        return $data;
    }

    public function updateBook(array $data): array
    {
        $query = $this->connection->prepare(
            "UPDATE books 
            SET author=:author, edition=:edition, price=:price  
            WHERE bookId = :bookId"
        );
        $result = $query->execute([
            'bookId' => $data['bookId'],
            'author' => $data['author'], 
            'edition' => $data['edition'],
            'price'  => $data['price'],
        ]);
        return $this->getBook($data['bookId']);
    }

    public function deleteBook(int $bookId): bool
    {
        $query = $this->connection->prepare("DELETE FROM books WHERE bookId=:bookId");
        $result = $query->execute(['bookId' => $bookId]);
        var_dump($result);
        return $result;
    }
}

$crud = new Crud([
    'host' => 'localhost', 
    'db' => 'ojlinks_api', 
    'username' => 'root', 
    'password' => '']
);

$books = $crud->getBooks();
if (count($books) && array_key_exists('title', $books[0])) {
    $title = $books[0]['title'];
    $author = $books[0]['author'];
    echo "First Book: $title by $author \n";  
}

$bookId = 7;
$book = $crud->getBook($bookId);
if (array_key_exists('title', $book)) {
    $title = $book['title'];
    $author = $book['author'];
    echo "Book $bookId: $title by $author \n";
}

$newBook = $crud->addBook([
  'title' => 'Chemistry for kids',
  'author' => 'Ababio Junior',
  'edition' => '7th Edition',
  'price' => 2380,
  'subcategoryId' => 2,
]);
if (array_key_exists('title', $newBook)) {
    $bookId = $newBook['bookId'];
    $title = $newBook['title'];
    $author = $newBook['author'];
    echo "New Book $bookId: $title by $author \n";
}

$updatedBook = $crud->updateBook([
    'bookId' => 158,
    'author' => 'Ababio and folks tale',
    'edition' => '10th Edition',
    'price' => 6800,
]);
if (array_key_exists('title', $updatedBook)) {
    $author = $updatedBook['author'];
    $title = $updatedBook['title'];
    $edition = $updatedBook['edition'];
    $price = $updatedBook['price'];
    echo "Updated Book: $title by $author, $edition now $price!\n";
}

$bookId = 157;
$result = $crud->deleteBook($bookId);
if ($result) {
    echo "Book $bookId has been deleted";
}

/**
 * For other options see https://gist.github.com/Tochukz/84a7f6dabcff3efac5245724c9e4cd02
 */