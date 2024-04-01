class MyRequest{
  method:string;
  uri: string;
  version: string;
  message: string;
  response: string = undefined;
  fulfilled: boolean = false;

  constructor(method: string, uri: string, version: string, message: string){
    this.method = method;
    this.uri = uri;
    this.version = version;
    this.message = message;
  }
}

let myData = new MyRequest('GET', 'http://google.com', 'HTTP/1.1', '');

console.log(myData);