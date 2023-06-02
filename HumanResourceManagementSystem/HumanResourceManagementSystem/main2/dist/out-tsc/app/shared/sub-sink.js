"use strict";
exports.__esModule = true;
exports.SubSink = void 0;
/**
 * Subscription sink that holds Observable subscriptions
 * until you call unsubscribe on it in ngOnDestroy.
 */
var SubSink = /** @class */ (function () {
    /**
     * Subscription sink that holds Observable subscriptions
     * until you call unsubscribe on it in ngOnDestroy.
     *
     * @example
     * In Angular:
     * ```
     *   private subs = new SubSink();
     *   ...
     *   this.subs.sink = observable$.subscribe(
     *   this.subs.add(observable$.subscribe(...));
     *   ...
     *   ngOnDestroy() {
     *     this.subs.unsubscribe();
     *   }
     * ```
     */
    function SubSink() {
        this._subs = [];
        // constructor
    }
    /**
     * Add subscriptions to the tracked subscriptions
     * @example
     *  this.subs.add(observable$.subscribe(...));
     */
    SubSink.prototype.add = function () {
        var subscriptions = [];
        for (var _i = 0; _i < arguments.length; _i++) {
            subscriptions[_i] = arguments[_i];
        }
        this._subs = this._subs.concat(subscriptions);
    };
    Object.defineProperty(SubSink.prototype, "sink", {
        /**
         * Assign subscription to this sink to add it to the tracked subscriptions
         * @example
         *  this.subs.sink = observable$.subscribe(...);
         */
        set: function (subscription) {
            this._subs.push(subscription);
        },
        enumerable: false,
        configurable: true
    });
    /**
     * Unsubscribe to all subscriptions in ngOnDestroy()
     * @example
     *   ngOnDestroy() {
     *     this.subs.unsubscribe();
     *   }
     */
    SubSink.prototype.unsubscribe = function () {
        this._subs.forEach(function (sub) { return sub && sub.unsubscribe(); });
        this._subs = [];
    };
    return SubSink;
}());
exports.SubSink = SubSink;
//# sourceMappingURL=sub-sink.js.map