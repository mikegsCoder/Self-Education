const handlers = {};

function match(method, url) {
    const methods = handlers[url] || {};

    const handler = methods[method];

    if(handler == undefined) {
        return defaultHandler;
    } else {
        return handler;
    }
}

