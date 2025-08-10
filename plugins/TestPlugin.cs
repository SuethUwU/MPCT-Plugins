package com.cloudstream.test

import com.lagradost.cloudstream3.*

class TestPlugin : MainPlugin() {
    override var mainUrl = "https://example.com"
    override var name = "Test Plugin"
    override val supportedTypes = setOf(TvType.Movie)

    override suspend fun load() {
        // Empty
    }
}
