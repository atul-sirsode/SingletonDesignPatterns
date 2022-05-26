# SingletonDesignPatterns

1) SingletonDesignPatternSimple :: simple design pattern class  work fine in single thread envionment but it does fail in multi thread env.
2) SingletonDesignPatternWithLock :: single design pattern class with lock, this will work in both single thread as well as with multi thread env, but there is small glich in this implimentation. every time locking happen on object irrespective of instance null or not.
3) SingletonDesignPatternWithDoubleLocking :: in this class, we have added extra check of instance null check point, just to make sure if instance is null then only
apply lock
4) SingletonDesignPatternWithEagerLoading :: with static keyword eager loading
5) SingletonDesignPatternWithLazyLoad :: with Lazy loading
