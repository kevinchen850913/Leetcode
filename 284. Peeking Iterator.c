//這題用c寫根用其他語言完全不一樣，
//主要是Iterator的int (*next)();想要取得數值就一定會移動指標，
//所以會需要用bool hasPeeked來切換動作，有夠詭異。

/*
 *	struct Iterator {
 *		// Returns true if the iteration has more elements.
 *		bool (*hasNext)();
 *
 * 		// Returns the next element in the iteration.
 *		int (*next)();
 *	};
 */

struct PeekingIterator {
    struct Iterator* iterator;
    bool hasPeeked;
    int val;
};

struct PeekingIterator* Constructor(struct Iterator* iter) {
    struct PeekingIterator* piter = malloc(sizeof(struct PeekingIterator));
    piter->iterator = iter;
    piter->hasPeeked = false;
    return piter;
}

int peek(struct PeekingIterator* obj) {
    if (!obj->hasPeeked)
    {
        obj->val = obj->iterator->next();
        obj->hasPeeked = true;
    }
    return obj->val;
}

int next(struct PeekingIterator* obj) {
    if (obj->hasPeeked)
    {
        obj->hasPeeked = false;
    }
    else
    {
        obj->val = obj->iterator->next();
    }
    return obj->val;
}

bool hasNext(struct PeekingIterator* obj) {
    return obj->hasPeeked == true || obj->iterator->hasNext();
}

/**
 * Your PeekingIterator struct will be instantiated and called as such:
 * PeekingIterator* obj = peekingIteratorCreate(arr, arrSize);
 * int param_1 = peek(obj);
 * int param_2 = next(obj);
 * bool param_3 = hasNext(obj);
 * peekingIteratorFree(obj);
*/