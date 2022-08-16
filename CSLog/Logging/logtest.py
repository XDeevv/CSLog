#This is just a small test im doing for the future logging system
#In python (as you see)

import logging 

fname = "test.log"

if __name__ == "__main__":
    try:
        logging.basicConfig(filename=fname, format='%(asctime)s %(message)s', filemode='w') 
        logger=logging.getLogger() 
        logger.setLevel(logging.DEBUG) #Set to debug

        #Run some tests, for now
        logger.debug("Debug message") 
        logger.info("Info message") 
        logger.warning("Warning message") 
        logger.error("Error message") 
        logger.critical("Fatal (something like that) message")
        print("Done") 
    except:
        print("Something went wrong :(")
    