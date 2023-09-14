using graph7;

var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddGraphQLServer()
    .AddDocumentFromString(@"

    type Query {
        book(title: String): Book
        books: [Book]
        author: Author
    }

    type Book {
        title: String
        author: Author
    }
    type Author {
        name: String
    }
    
    ")
    .BindRuntimeType<Query>()
    .BindRuntimeType<Book>()
    .BindRuntimeType<Author>();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGraphQL();

app.Run();
