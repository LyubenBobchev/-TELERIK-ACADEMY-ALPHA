const controller = (function () {
    const modelFactory = factory();
    const database = databaseFunction();
    const commands = commandsFunc(modelFactory, database);
    const commandProcessor = commandProcessorFunction(commands);

    return {
       x: console.log('controller'),
        commandProcessor
    };
})();